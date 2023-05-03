/*
 * C-MCU2.c
 *
 * Created: 27/04/2023 12:37:02
 * Author : D'haeneThian
 */ 

#include <avr/io.h>
#define F_CPU 3686400L
#include <avr/interrupt.h>
#include <util/delay.h>
#include <stdbool.h>
#include <stdlib.h>
#include <avr/pgmspace.h>
#include <math.h>
#include <stdio.h>
#include <string.h>


void serieel_init0(void);
char OmzettenNaarHex(char i, char status);

void sendString0(char s[]);
void sendChar0(char data);

void init_ingangen(void);
char bezetteparkeerplaatsen[27];

volatile unsigned char ticks1s;
volatile unsigned char ticks16;
void init_timer(void);

int main(void)
{
    serieel_init0();
	init_ingangen();
	init_timer();
	
    while (1) 
    {
		//Inlezen alle ingangen
		//P1
		if(PINC &(PINC0)) {bezetteparkeerplaatsen[1]=0;}
		if(!(PINC &(PINC0))){bezetteparkeerplaatsen[1]=1;}
			
		//P2
		if(PINC &(PINC0)) {bezetteparkeerplaatsen[2]=0;}
		if(!(PINC &(PINC0))){bezetteparkeerplaatsen[2]=1;}
		
		//P3
		if(PINC &(PINC0)) {bezetteparkeerplaatsen[3]=0;}
		if(!(PINC &(PINC0))){bezetteparkeerplaatsen[3]=1;}
		
		//P4
		if(PINC &(PINC0)) {bezetteparkeerplaatsen[4]=1;}
		if(!(PINC &(PINC0))){bezetteparkeerplaatsen[4]=0;}
			
		//P5
		if(PINC &(PINC1)) {bezetteparkeerplaatsen[5]=1;}
		if(!(PINC &(PINC1))){bezetteparkeerplaatsen[5]=0;}

		//P6
		if(PINC &(PINC2)) {bezetteparkeerplaatsen[6]=1;}
		if(!(PINC &(PINC2))){bezetteparkeerplaatsen[6]=0;}

		//P7
		if(PINC &(PINC3)) {bezetteparkeerplaatsen[7]=1;}
		if(!(PINC &(PINC3))){bezetteparkeerplaatsen[7]=0;}

		//P8
		if(PINC &(PINC4)) {bezetteparkeerplaatsen[8]=1;}
		if(!(PINC &(PINC4))){bezetteparkeerplaatsen[8]=0;}

		//P9
		if(PINC &(PINC5)) {bezetteparkeerplaatsen[9]=1;}
		if(!(PINC &(PINC5))){bezetteparkeerplaatsen[9]=0;}

		//P10
		if(PINC &(PINC6)) {bezetteparkeerplaatsen[10]=1;}
		if(!(PINC &(PINC6))){bezetteparkeerplaatsen[10]=0;}

		//P11
		if(PINC &(PINC7)) {bezetteparkeerplaatsen[11]=1;}
		if(!(PINC &(PINC7))){bezetteparkeerplaatsen[11]=0;}

		//P12
		if(PIND &(PIND6)) {bezetteparkeerplaatsen[12]=1;}
		if(!(PIND &(PIND6))){bezetteparkeerplaatsen[12]=0;}

		//P13
		if(PIND &(PIND5)) {bezetteparkeerplaatsen[13]=1;}
		if(!(PIND &(PIND5))){bezetteparkeerplaatsen[13]=0;}

		//P18
		if(PIND &(PIND4)) {bezetteparkeerplaatsen[18]=1;}
		if(!(PIND &(PIND4))){bezetteparkeerplaatsen[18]=0;}

		//P19
		if(PIND &(PIND3)) {bezetteparkeerplaatsen[19]=1;}
		if(!(PIND &(PIND3))){bezetteparkeerplaatsen[19]=0;}

		//P20
		if(PIND &(PIND2)) {bezetteparkeerplaatsen[20]=1;}
		if(!(PIND &(PIND2))){bezetteparkeerplaatsen[20]=0;}

		//P21
		if(PINB &(PINB2)) {bezetteparkeerplaatsen[21]=1;}
		if(!(PINB &(PINB2))){bezetteparkeerplaatsen[21]=0;}

		//P22
		if(PINB &(PINB3)) {bezetteparkeerplaatsen[22]=1;}
		if(!(PINB &(PINB3))){bezetteparkeerplaatsen[22]=0;}
	
		//P23
		if(PINB &(1<<PINB2)) {bezetteparkeerplaatsen[23]=1;}
		if(!(PINB &(1<<PINB2))){bezetteparkeerplaatsen[23]=0;}

		//P24
		if(PINB &(1<<PINB1)) {bezetteparkeerplaatsen[24]=1;}
		if(!(PINB &(1<<PINB1))){bezetteparkeerplaatsen[24]=0;}

		//P25
		if(PINB &(1<<PINB0)) {bezetteparkeerplaatsen[25]=1;}
		if(!(PINB &(1<<PINB0))){bezetteparkeerplaatsen[25]=0;}

		//P26
		if(PINA &(1<<PINA0)) {bezetteparkeerplaatsen[26]=1;}
		if(!(PINA &(1<<PINA0))){bezetteparkeerplaatsen[26]=0;}
			
		if(ticks1s)
		{
			for (int i = 0; i < 26; i++)
			{
				sendChar0(OmzettenNaarHex(i,bezetteparkeerplaatsen[i]));
				_delay_ms(20);
			}
			ticks1s=0;
		}
		
		
    }
}

char OmzettenNaarHex(char i, char status)
{
	//P1
	if(i==1 && status==0) {return 0x01;}
	if(i==1 && status==1) {return 0x02;}
	//P2
	if(i==2 && status==0) {return 0x03;}
	if(i==2 && status==1) {return 0x04;}
	//P3
	if(i==3 && status==0) {return 0x05;}
	if(i==3 && status==1) {return 0x06;}
	//P4
	if(i==4 && status==0) {return 0x07;}
	if(i==4 && status==1) {return 0x08;}
	//P5
	if(i==5 && status==0) {return 0x09;}
	if(i==5 && status==1) {return 0x10;}
	//P6
	if(i==6 && status==0) {return 0x11;}
	if(i==6 && status==1) {return 0x12;}
	//P7
	if(i==7 && status==0) {return 0x13;}
	if(i==7 && status==1) {return 0x14;}
	//P8
	if(i==8 && status==0) {return 0x15;}
	if(i==8 && status==1) {return 0x16;}
	//P9
	if(i==9 && status==0) {return 0x17;}
	if(i==9 && status==1) {return 0x18;}
	//P10
	if(i==10 && status==0) {return 0x19;}
	if(i==10 && status==1) {return 0x20;}
	//P11
	if(i==11 && status==0) {return 0x21;}
	if(i==11 && status==1) {return 0x22;}
	//P12
	if(i==12 && status==0) {return 0x23;}
	if(i==12 && status==1) {return 0x24;}
	//P13
	if(i==13 && status==0) {return 0x25;}
	if(i==13 && status==1) {return 0x26;}
	
	////P14
	//if(i==14 && status==0) {return 0x27;}
	//if(i==14 && status==1) {return 0x28;}
	////P15
	//if(i==15 && status==0) {return 0x29;}
	//if(i==15 && status==1) {return 0x30;}
	////P16
	//if(i==16 && status==0) {return 0x31;}
	//if(i==16 && status==1) {return 0x32;}
	////P17
	//if(i==17 && status==0) {return 0x33;}
	//if(i==17 && status==1) {return 0x34;}
		
	//P18
	if(i==18 && status==0) {return 0x35;}
	if(i==18 && status==1) {return 0x36;}
	//P19
	if(i==19 && status==0) {return 0x37;}
	if(i==19 && status==1) {return 0x38;}
	//P20
	if(i==20 && status==0) {return 0x39;}
	if(i==20 && status==1) {return 0x40;}
	//P21
	if(i==21 && status==0) {return 0x41;}
	if(i==21 && status==1) {return 0x42;}
	//P22
	if(i==22 && status==0) {return 0x43;}
	if(i==22 && status==1) {return 0x44;}
	//P23
	if(i==23 && status==0) {return 0x45;}
	if(i==23 && status==1) {return 0x46;}
	//P24
	if(i==24 && status==0) {return 0x47;}
	if(i==24 && status==1) {return 0x48;}
	//P25
	if(i==25 && status==0) {return 0x49;}
	if(i==25 && status==1) {return 0x50;}
	//P26
	if(i==26 && status==0) {return 0x51;}
	if(i==26 && status==1) {return 0x52;}

	
	
}

void serieel_init0(void)
{
	//de pin PD2 als ingang (RX), de pin PD3 als uitgang (TX) met een hoog niveau
	DDRD &=~(1<<DDRD0);
	DDRD |=(1<<DDRD1);
	
	//init seriële communicatie
	//USART0, 9600 baud, 8 databit, geen pariteit, 1 stopbit, geen interrupt werking
	UCSR0A &=~(1<<U2X0); //normale snelheid
	UBRR0 = 23; //Instellen van Baudrate op 9600bps
	UCSR0C |= ((1<<UCSZ00)|(1<<UCSZ01)); //8 databits instellen
	UCSR0B &=~ (1<<UCSZ02);	//8 databits instellen
	UCSR0C &=~ (1<<USBS0); //1 stopbit
	UCSR0C &=~(1<<UPM00)|(1<<UPM01); //geen pariteit
	UCSR0B |=((1<<RXEN0)|(1<<TXEN0)); //activeren zender en ontvanger
	UCSR0B |= (1<<RXCIE0); //activeren interrupt rx
}

ISR(USART0_RX_vect)
{
	//interrupt bij ontvangen van seriele communicatie
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

ISR (TIMER0_COMPA_vect)
{
	ticks16++;
	if(ticks16==64)
	{
		ticks16=0;
		ticks1s=1;
	}
}

void init_ingangen(void)
{
	//P1
	DDRA &=~ (1<<DDRA7);
	//P2
	DDRA &=~ (1<<DDRA4);
	//P3
	DDRA &=~ (1<<DDRA3);
	//P4
	DDRC &=~ (1<<DDRC0);
	//P5
	DDRC &=~ (1<<DDRC1);
	//P6
	DDRC &=~ (1<<DDRC2);
	//P7
	DDRC &=~ (1<<DDRC3);
	//P8
	DDRC &=~ (1<<DDRC4);
	//P9
	DDRC &=~ (1<<DDRC5);
	//P10
	DDRC &=~ (1<<DDRC6);
	//P11
	DDRC &=~ (1<<DDRC7);
	//P12
	DDRD &=~ (1<<DDRD6);
	//P13
	DDRD &=~ (1<<DDRD5);
	//P18
	DDRD &=~ (1<<DDRD4);
	//P19
	DDRD &=~ (1<<DDRD3);
	//P20
	DDRD &=~ (1<<DDRD2);
	//P21
	DDRB &=~ (1<<DDRB4);
	//P22
	DDRB &=~ (1<<DDRB3);
	//P23
	DDRB &=~ (1<<DDRB2);
	//P24
	DDRB &=~ (1<<DDRB1);
	//P25
	DDRB &=~ (1<<DDRB0);
	//P26
	DDRA &=~(1<<DDRA0);
}
