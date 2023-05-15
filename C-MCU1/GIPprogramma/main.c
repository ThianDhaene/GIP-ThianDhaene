/*
* GIPprogramma.c
*
* Created: 23/01/2023 15:19:28
* Author : D'haeneThian
*/


//Toevoegen van alle libraries
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

//INIT AANSTUREN SLAGBOMEN
char Servo1(unsigned char graden);
char Servo2(unsigned char graden);
void init_servo();
char slagboom1 = 0;
char slagboom2 = 0;

//INIT AANSTUREN 7SEGMENT
volatile unsigned char waarde_e;
volatile unsigned char waarde_t;
volatile unsigned char linksrechts;
volatile char array1[]={0xC0,0xF9,0xA4,0xB0,0x99,0x92,0x82,0xF8,0x80,0x90};
void init_7seg(void);
char waarde7(char waarde);

//AANSTUREN I2C
void I2C(char adres, char );
volatile unsigned char i2c1 = 0;
char I2C_P1_aangepast=0;
char I2C_P2_aangepast=0;

//DOORSTUREN STATUS PARKING
volatile unsigned char ticks4s;
volatile unsigned char ticks64;
char bezetteparkeerplaatsen[27];
char buffer[5];
char bezetteplaatsen=0;

//INIT FUNCTIES USART0
void serieel_init0(void);
void sendChar0(char data);
void sendString0(char s[]);

//INIT FUNCTIES USART1
void serieel_init1(void);
void sendChar1(char data);
void sendString1(char s[]);


//INIT ONTVANGEN VIA C#
#define MSG_NEW 1
#define MSG_OLD 2
char rx_buf[160];
volatile unsigned char msg=MSG_OLD;

int main(void)
{
	//CONTROLE-LED ALS UITGANG
	DDRD |= (1<<DDRD7);
	
	//PORTA ALS UITGANG VOOR 7-SEGMENT
	DDRA = 0xFF;
	
	//PB0 EN PB1 ALS INGANG VOOR MULTIPLEXEN
	//PB0 LAAG EN PB1 HOOG OM TE STARTEN
	DDRB=(1<<DDRB0)|(1<<DDRB1);
	PORTB&=~(1<<PORTB0);
	PORTB|=(1<<PORTB1);
	
	//INIT 4 PARKEERPLAATSEN MCU1
	//P14 P15 P16 P17
	DDRC &=~ (1<<DDRC4)|(1<<DDRC5)|(1<<DDRC6)|(1<<DDRC7);
	
	
	//OPSTARTEN VERSCHILLENDE COMPONENTEN
	//SERVOMOTOREN
	init_servo();
	//USART0 & USART1
	serieel_init0();
	serieel_init1();
	//I2C
	twi_init();
	//7-SEGMENT
	init_7seg();
	
	//SLAGBOMEN NAAR STANDAARD POSITIE ZETTEN
	Servo1(0);
	Servo2(90);
	_delay_ms(200);
	Servo1(90);
	Servo2(180);
	
	//Statusled knipperen
	for (int i = 0; i < 10; i++) {
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
		if (ticks4s)
		{
			bezetteplaatsen=0;
			for (int i = 1; i <= 26; i++)
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
			ticks4s=0;
			waarde7(26-bezetteplaatsen);
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
	if(linksrechts==1)
	{
		PORTA = array1[waarde_e];
		linksrechts=0;
	}
	else
	{
		PORTA = array1[waarde_t];
		linksrechts=1;
	}
	ticks64++;
	if(ticks64==64)
	{
		ticks64=0;
		ticks4s=1;
	}
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

ISR(USART0_RX_vect)
{
	char data = UDR0;
	//P1
	if(data==0x01 )
	{
		if(bezetteparkeerplaatsen[1]!=0)
		{
			bezetteparkeerplaatsen[1]=0;
			if(i2c1>0) i2c1-=1;
		}
	}
	else if(data==0x02)
	{
		if(bezetteparkeerplaatsen[1]!=1)
		{
			bezetteparkeerplaatsen[1]=1;
			i2c1+=1;
		}
	}
	
	//P2
	if(data==0x03)
	{
		if(bezetteparkeerplaatsen[2]!=0)
		{
			bezetteparkeerplaatsen[2]=0;
			if(i2c1>=2) i2c1-=2;
		}
	}
	if(data==0x04)
	{
		if(bezetteparkeerplaatsen[2]!=1)
		{
			bezetteparkeerplaatsen[2]=1;
			i2c1+=2;
		}
	}
	
	//P3
	if(data==0x05)
	{
		if(bezetteparkeerplaatsen[3]!=0)
		{
			bezetteparkeerplaatsen[3]=0;
			if(i2c1>=4) i2c1-=4;
		}
	}
	if(data==0x06)
	{
		if(bezetteparkeerplaatsen[3]!=1)
		{
			bezetteparkeerplaatsen[3]=1;
			i2c1+=4;
		}
	}
	//P4
	if(data==0x07)
	{
		if(bezetteparkeerplaatsen[4]!=0)
		{
			bezetteparkeerplaatsen[4]=0;
			if(i2c1>=8) i2c1-=8;
		}
	}
	if(data==0x08)
	{
		if(bezetteparkeerplaatsen[4]!=1)
		{
			bezetteparkeerplaatsen[4]=1;
			i2c1+=8;
		}
	}
	//P5
	if(data==0x09)
	{
		if(bezetteparkeerplaatsen[5]!=0)
		{
			bezetteparkeerplaatsen[5]=0;
			if(i2c1>=16) i2c1-=16;
		}
	}
	if(data==0x10)
	{
		if(bezetteparkeerplaatsen[5]!=1)
		{
			bezetteparkeerplaatsen[5]=1;
			i2c1+=16;
		}
	}
	//P6
	if(data==0x11)
	{
		if(bezetteparkeerplaatsen[6]!=0)
		{
			bezetteparkeerplaatsen[6]=0;
			if(i2c1>=32) i2c1-=32;
		}
	}
	if(data==0x12)
	{
		if(bezetteparkeerplaatsen[6]!=1)
		{
			bezetteparkeerplaatsen[6]=1;
			i2c1+=32;
		}
	}
	//P7
	if(data==0x13)
	{
		if(bezetteparkeerplaatsen[7]!=0)
		{
			bezetteparkeerplaatsen[7]=0;
			if(i2c1>=64) i2c1-=64;
		}
	}
	if(data==0x14)
	{
		if(bezetteparkeerplaatsen[7]!=1)
		{
			bezetteparkeerplaatsen[7]=1;
			i2c1+=64;
		}
	}
	//P8
	if(data==0x15)
	{
		if(bezetteparkeerplaatsen[8]!=0)
		{
			bezetteparkeerplaatsen[8]=0;
			if(i2c1>=128) i2c1-=128;
		}
	}
	if(data==0x16)
	{
		if(bezetteparkeerplaatsen[8]!=1)
		{
			bezetteparkeerplaatsen[8]=1;
			i2c1+=128;
		}
	}
	
	I2C(0x40,i2c1);
	if(data==0x17){bezetteparkeerplaatsen[9]=0;}
	if(data==0x18){bezetteparkeerplaatsen[9]=1;}
	
	if(data==0x19){bezetteparkeerplaatsen[10]=0;}
	if(data==0x20){bezetteparkeerplaatsen[10]=1;}
	
	if(data==0x21){bezetteparkeerplaatsen[11]=0;}
	if(data==0x22){bezetteparkeerplaatsen[11]=1;}
	
	if(data==0x23){bezetteparkeerplaatsen[12]=0;}
	if(data==0x24){bezetteparkeerplaatsen[12]=1;}
	
	if(data==0x25){bezetteparkeerplaatsen[13]=0;}
	if(data==0x26){bezetteparkeerplaatsen[13]=1;}
	
	if(data==0x35){bezetteparkeerplaatsen[18]=0;}
	if(data==0x36){bezetteparkeerplaatsen[18]=1;}
	
	if(data==0x37){bezetteparkeerplaatsen[19]=0;}
	if(data==0x38){bezetteparkeerplaatsen[19]=1;}
	
	if(data==0x39){bezetteparkeerplaatsen[20]=0;}
	if(data==0x40){bezetteparkeerplaatsen[20]=1;}
	
	if(data==0x41){bezetteparkeerplaatsen[21]=0;}
	if(data==0x42){bezetteparkeerplaatsen[21]=1;}
	
	if(data==0x43){bezetteparkeerplaatsen[22]=0;}
	if(data==0x44){bezetteparkeerplaatsen[22]=1;}
	
	if(data==0x45){bezetteparkeerplaatsen[23]=0;}
	if(data==0x46){bezetteparkeerplaatsen[23]=1;}
	
	if(data==0x47){bezetteparkeerplaatsen[24]=0;}
	if(data==0x48){bezetteparkeerplaatsen[24]=1;}
	
	if(data==0x49){bezetteparkeerplaatsen[25]=0;}
	if(data==0x50){bezetteparkeerplaatsen[25]=1;}
	
	if(data==0x51){bezetteparkeerplaatsen[26]=0;}
	if(data==0x52){bezetteparkeerplaatsen[26]=1;}
	
	//slagboom1
	if(data==0x53)
	{
		Servo1(0);
	}
	if(data==0x54)
	{
		Servo1(90);
	}
	
	//slagboom2
	if(data==0x55)
	{
		Servo2(90);
	}
	if(data==0x56)
	{
		Servo2(180);
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