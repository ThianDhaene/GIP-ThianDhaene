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

void sendString1(char s[]);
void sendChar1(char data);

int main(void)
{
    serieel_init0();
	
	DDRD |= ((1<<DDRD3) |(1<<DDRD4) |(1<<DDRD5) | (1<<DDRD6));
	
    while (1) 
    {
		
    }
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

