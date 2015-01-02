#include <16f877a.h>   //pic a utilizar
#device adc=10         //bits del adc
#fuses XT,NOWDT        //ordenes para el programador
#use delay(clock=4000000)
#use rs232(baud=9600,xmit=pin_c6,rcv=pin_c7, bits=8, parity=N , STREAM=PC, stream=Module)   //manejo del RS232
#include <lcd.c>
#use standard_io(c,b)

float sensor0,temperatura,temperaturaf,temperaturak; // sensor de temperatura
int valor0,x;

void verlcd (void);

void main(void)
{
	setup_adc_ports(AN0_AN1_AN2_AN4_AN5_AN6_AN7_VSS_VREF);
	setup_adc(ADC_CLOCK_INTERNAL);
	set_tris_B(0x07); // port RB2, RB1 Y RB0 Entradas Y EL RESTO SALIDAS
	lcd_init();
	valor0=0;
	sensor0=0;
	temperatura=0;

	while(true)
	{
		verlcd ();
		set_adc_channel (0);
		delay_ms(30);    //para que se estabilice
		sensor0=read_adc ();
		delay_ms(10);    //para que se estabilice
		temperatura=(sensor0*.48);
		temperaturaf=((temperatura*1.8)+32);
		temperaturak=temperatura+273;

		// Leer el canal AN2  esta entrada es voltaje de referencia (GND)
		set_adc_channel (2);
		delay_ms (1);
		//medicion2=read_adc ();
		;

		// Leer el canal AN3  esta entrada es voltaje de referencia (VCC)
		set_adc_channel (3);
		delay_ms (1);

		// Detectar puertos B2, B1, B0.
	}
}

void verlcd (void)
{
	//Lcd_putc( "\f");
	delay_ms(1);
	lcd_gotoxy(1,1);
	printf(lcd_putc,"\T=%1.1fC T=%1.1fF \nT=%1.1fK",temperatura,temperaturaf,temperaturak);
	delay_ms(1);
	printf("\n\r temp:%f" ,temperatura); 
}

