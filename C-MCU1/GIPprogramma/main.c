/*
* GIPprogramma.c
*
* Created: 23/01/2023 15:19:28
* Author : D'haeneThian
*/

#include <avr/io.h>
#define F_CPU 3686400L
#include <avr/interrupt.h>
#include <util/delay.h>
#include <stdbool.h>
#include "twi_master.h"
#include <stdlib.h>
#include <avr/pgmspace.h>
#include <math.h>
#include <stdio.h>
#include <string.h>

//AANSTUREN SLAGBOMEN
char Servo1(unsigned char graden);
char Servo2(unsigned char graden);
void init_servo();
unsigned char open1=0;
unsigned char open2=0;

//AANSTUREN 7SEGMENT
volatile unsigned char waarde_e;
volatile unsigned char waarde_t;
volatile unsigned char linkrechts;
volatile unsigned char teller=0;
volatile char array1[]={0xC0,0xF9,0xA4,0xB0,0x99,0x92,0x82,0xF8,0x80,0x90};
void init_7seg(void);
char waarde7(char waarde);

//Aansturen I2C
void I2C(char adres, char );

volatile char parkeerplaats1[]={0,0,0,0,0,0,0,0,0,0,0,0,0,0};
char slagboom1 = 0;
char slagboom2 = 0;

//Doorsturen status parking
volatile unsigned char ticks1s;
volatile unsigned char ticks16;
void init_timer(void);
char bezetteparkeerplaatsen[27];
char buffer[5];
char bezetteplaatsen=0;

char parkingstring[160];

void sendString0(char s[]);
void sendChar0(char data);

void sendString1(char s[]);
void sendChar1(char data);

void serieel_init1(void);
void serieel_init0(void);

#define MSG_NEW 1
#define MSG_OLD 2

char rx_buf[160];
volatile unsigned char msg=MSG_OLD;


int main(void)
{
	DDRD |= (1<<DDRD7);
	
	DDRB=(1<<DDRB0)|(1<<DDRB1);
	PORTB&=~(1<<PORTB0);
	PORTB|=(1<<PORTB1);
	
	//P14 P15 P16 P17
	DDRC &=~ (1<<DDRC4)|(1<<DDRC5)|(1<<DDRC6)|(1<<DDRC7);
	
	
	//opstarten van verschillende componenten
	init_servo();
	serieel_init1();
	serieel_init0();
	twi_init();
	init_timer();
	
	Servo1(0);
	Servo2(0);
	_delay_ms(200);
	Servo1(90);
	Servo2(90);
	
	//Statusled knipperen
	int i;
	for (i = 0; i < 10; i++) {
		PORTD |=(1<<PORTD7);
		_delay_ms(200);
		PORTD &=~(1<<PORTD7);
		_delay_ms(200);
		i++;
	}
	
	_delay_ms(100);
	sendString1("\r\nPARKING-OPGESTART");
	
	sei();
	while (1)
	{
		
		//Alle ingangen controlleren
		//P14
		if(PINC &(1<<PINC4)) { bezetteparkeerplaatsen[14]=1; }
		if(!(PINC &(1<<PINC4))) { bezetteparkeerplaatsen[14]=0; }
			
		//P15
		if(PINC &(1<<PINC5)) { bezetteparkeerplaatsen[15]=1; }
		if(!(PINC &(1<<PINC5))) { bezetteparkeerplaatsen[15]=0; }
		
		//P16
		if(PINC &(1<<PINC6)) { bezetteparkeerplaatsen[16]=1; }
		if(!(PINC &(1<<PINC6))) { bezetteparkeerplaatsen[16]=0; }
		
		//P17
		if(PINC &(1<<PINC7)) { bezetteparkeerplaatsen[17]=1; }
		if(!(PINC &(1<<PINC7))) { bezetteparkeerplaatsen[17]=0; }
		
		
		//Nieuwe seriele berichten verwerken
		if(msg==MSG_NEW)
		{
			PORTD |=(1<<PORTD7);
			msg=MSG_OLD;
			
			//ptr=strstr(rx_buf,"test");
			
			if(strstr(rx_buf,"slagboom1-0"))
			{
				slagboom1=0;
			}
			if(strstr(rx_buf,"slagboom1-1"))
			{
				slagboom1=1;
			}
			if(strstr(rx_buf,"slagboom1-2"))
			{
				slagboom1=2;
			}
		}
		if (ticks1s)
		{
			bezetteplaatsen=0;
			for (int i = 0; i < 26; i++)
			{
				if(bezetteparkeerplaatsen[i]==1)
				{
					bezetteplaatsen++;
					sprintf(buffer, "PB%d\r\n",i);
				}
				if(bezetteparkeerplaatsen[i]==0)
				{
					sprintf(buffer, "PL%d\r\n",i);
				}
				sendString1(buffer);
				_delay_ms(20);
			}
			sprintf(buffer, "B%d\r\n",bezetteplaatsen);
			sendString1(buffer);
			ticks1s=0;
		}
		
	}
}

char Servo1(unsigned char graden)
{
	OCR1A=(231+(graden*5.12222));
	return 1;
}
char Servo2(unsigned char graden)
{
	OCR1B=(231+(graden*5.12222));
	return 1;
}

void I2C(char adres, char waarde)
{
	twi_start();
	twi_write(adres);
	twi_write(255-waarde);
	twi_stop();
}

void serieel_init1(void)
{
	//de pin PD2 als ingang (RX), de pin PD3 als uitgang (TX) met een hoog niveau
	DDRD &=~(1<<DDRD2);
	DDRD |=(1<<DDRD3);
	
	//init seriële communicatie
	//USART0, 9600 baud, 8 databit, geen pariteit, 1 stopbit, geen interrupt werking
	UCSR1A &=~(1<<U2X1); //normale snelheid
	UBRR1 =23; //Instellen van Baudrate op 9600bps
	UCSR1C |= ((1<<UCSZ10)|(1<<UCSZ11)); //8 databits instellen
	UCSR1B &=~ (1<<UCSZ12);	//8 databits instellen
	UCSR1C &=~ (1<<USBS1); //1 stopbit
	UCSR1C &=~(1<<UPM10)|(1<<UPM11); //geen pariteit
	UCSR1B |=((1<<RXEN1)|(1<<TXEN1)); //activeren zender en ontvanger
	UCSR1B |= (1<<RXCIE1); //activeren interrupt rx

}

void serieel_init0(void)
{
	//de pin PD2 als ingang (RX), de pin PD3 als uitgang (TX) met een hoog niveau
	DDRD &=~(1<<DDRD0);
	DDRD |=(1<<DDRD1);
	
	//init seriële communicatie
	//USART0, 9600 baud, 8 databit, geen pariteit, 1 stopbit, geen interrupt werking
	UCSR0A &=~(1<<U2X0); //normale snelheid
	UBRR0 =23; //Instellen van Baudrate op 9600bps
	UCSR0C |= ((1<<UCSZ00)|(1<<UCSZ01)); //8 databits instellen
	UCSR0B &=~ (1<<UCSZ02);	//8 databits instellen
	UCSR0C &=~ (1<<USBS0); //1 stopbit
	UCSR0C &=~(1<<UPM00)|(1<<UPM01); //geen pariteit
	UCSR0B |=((1<<RXEN0)|(1<<TXEN0)); //activeren zender en ontvanger
	UCSR0B |= (1<<RXCIE0); //activeren interrupt rx

}

void sendChar0(char data)
{
	while( ! (UCSR0A & 0x20) ); //Er word gewacht tot dat de vlag UDRE0 1 is en dus het register UDR0 leeg is
	UDR0 = data; //De te versturen data word in register UDR0 geplaatst
}

void sendString0(char s[])
{
	int i = 0;						//
	while(i < 64)					//Blijft lus doorlopen zolang i kleiner is dan 64 om niet over de maximum hoeveelheid data te gaan
	{
		if( s[i] == '\0' ) break;	//
		sendChar0(s[i++]);			//
	}
}

void sendChar1(char data)
{
	while( ! (UCSR1A & 0x20) ); //Er word gewacht tot dat de vlag UDRE0 1 is en dus het register UDR0 leeg is
	UDR1 = data; //De te versturen data word in register UDR0 geplaatst
}

void sendString1(char s[])
{
	int i = 0;						//
	while(i < 64)					//Blijft lus doorlopen zolang i kleiner is dan 64 om niet over de maximum hoeveelheid data te gaan
	{
		if( s[i] == '\0' ) break;	//
		sendChar1(s[i++]);			//
	}
}

void init_servo()
{
	//PRESCALER 8
	TCCR1B&=~((1<<CS12)|(1<<CS10));
	TCCR1B|=(1<<CS11);
	//OC1A INSTELLEN ALS UITGANG
	DDRD|=(1<<DDRD5);
	DDRD|=(1<<DDRD4);
	//WGM BITS MODE 14
	TCCR1A&=~(1<<WGM10);
	TCCR1A|=(1<<WGM11);
	TCCR1B|=((1<<WGM12)|(1<<WGM13));
	//COMBITS A instellen
	TCCR1A|=(1<<COM1A1);
	TCCR1A&=~(1<<COM1A0);
	//COMBITS B instellen
	TCCR1A|=(1<<COM1B1);
	TCCR1A&=~(1<<COM1B0);
	//ICR1
	ICR1 = 9215; // aantal telpulsen
	//OCR1A
	OCR1A = 231; //
	OCR1B = 231; //
}

ISR (TIMER0_COMPA_vect)
{
	PORTB ^=(1<<PORTB0)|(1<<PORTB1);
	if(linkrechts==1)
	{
		PORTC = array1[waarde_e];
		linkrechts=0;
	}
	else
	{
		PORTC = array1[waarde_t];
		linkrechts=1;
	}
	ticks16++;
	if(ticks16==64)
	{
		ticks16=0;
		ticks1s=1;
	}
	
}

void init_7seg(void)
{
	TCCR0A |= (1<<WGM01);	//Instellen WGM01 op 1 in TCCR0A
	TCCR0A &=~(1<<WGM00);	//Instellen WGM00 op 0 in TCCR0A
	TCCR0B &=~((1<<WGM02) | (1<<CS01));		//Instellen  WGM02 en CS01 op 0 in TCCR0B
	TCCR0B |= ((1<<CS02)| (1<<CS00));		//Instellen CS02 en CS00 op 1 in TCCR0B
	OCR0A = 20;
	TIMSK0 |= (1<<OCIE0A);
}

char waarde7(char waarde)
{
	waarde_e=waarde % 10;
	waarde_t=waarde /10;
	return 1;
}

ISR(USART1_RX_vect)
{
	static unsigned char rx_ptr=0;
	rx_buf[rx_ptr]=UDR1;
	if(rx_buf[rx_ptr]=='\r')
	{
		rx_buf[rx_ptr]='\0';
		rx_ptr=0;
		msg=MSG_NEW;
	}
	else rx_ptr++;
}

void init_timer(void)
{
	//init
	DDRA &=~(1<<DDRA0);
	DDRC |=(1<<DDRC0);
	TCCR0A |= (1<<WGM01);	//Instellen WGM01 op 1 in TCCR0A
	TCCR0A &=~(1<<WGM00);	//Instellen WGM00 op 0 in TCCR0A
	TCCR0B &=~((1<<WGM02) | (1<<CS01));		//Instellen  WGM02 en CS01 op 0 in TCCR0B
	TCCR0B |= ((1<<CS02)| (1<<CS00));		//Instellen CS02 en CS00 op 1 in TCCR0B
	OCR0A = 224;
	TIMSK0 |= (1<<OCIE0A);
	sei();
}