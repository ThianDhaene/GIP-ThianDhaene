#include <avr/io.h>
#include <util/twi.h>
#include "twi_master.h"		

#define F_CPU 3686640L

void twi_init(void)
{
	TWBR = 42;	//voor snelheid van ongeveer 36864Hz
}


//genereren van de startconditie
//terugkeerwaarde = 0 bij fout
unsigned char twi_start(void)
{

TWCR = 0;	// wis TWI controle register
TWCR = (1<<TWINT) | (1<<TWSTA) | (1<<TWEN); // zend START conditie 
while( !(TWCR & (1<<TWINT)) ); //wachten op het einde van de transmissie
if((TWSR & 0xF8) != TW_START) return 0;  //controleren of de start conditie met succes is verstuurd
return 1;
}

//schrijven van een byte als master
//een byte kan zowel data als adres zijn
//terugkeerwaarde is één (1) bij succes
unsigned char twi_write(unsigned char data)
{
TWDR = data;	//laden van een byte  in het dataregister TWDR
TWCR = (1<<TWINT) | (1<<TWEN);	//starten van het versturen van de byte
while( !(TWCR & (1<<TWINT)) );	//wachten tot het einde van de transmissie
//if( (TWSR & 0xF8) != TW_MT_DATA_ACK ) return 0; //controleren op ACK van SLAVE
unsigned char twst = TW_STATUS & 0xF8; //controleren op ACK van SLAVE in zowel READ als WRITE mode
if ( (twst != TW_MT_SLA_ACK) && (twst != TW_MR_SLA_ACK) ) return 0;
return 1;
}


//lezen data met bevstinging van MASTER met ACK
unsigned char twi_read_ack(void)
{
TWCR = (1<<TWINT) | (1<<TWEN) | (1<<TWEA);  //start TWI module en stuur ACK na ontvangst
while( !(TWCR & (1<<TWINT)) ); //wachten tot einde transmissie
return TWDR;	//terugkeren met ontvangen data
}

//stoppen transmissie
void twi_stop(void)
{
TWCR = (1<<TWINT) | (1<<TWEN) | (1<<TWSTO); //versturen van een stop conditie
}

