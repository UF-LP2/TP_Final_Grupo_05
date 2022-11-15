///////////////////////////////////////////////////////////
//  cFurgoneta.cs
//  Implementation of the Class cFurgoneta
//  Generated by Enterprise Architect
//  Created on:      09-nov.-2022 15:59:26
//  Original author: HP
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



public class cFurgoneta : cVehiculos {

	public cFurgoneta(){
		Cant_Viajes = 1;
        Capacidad_Max_Combustible = 80; //litros
        Carga_Util = 3500; //kg
        Consumo = 0.069; //consumo de litros por kilometro
        dimens_vehiculo.ancho = 1.796; //m
        dimens_vehiculo.largo = 2.670; //m
        dimens_vehiculo.alto = 1.662; //m
        Peso_Max = 3500; //kg
        Viajes_Realizados = 0;
        Vol_Max = dimens_vehiculo.ancho * dimens_vehiculo.largo * dimens_vehiculo.alto; //m3
        distanciarecorrida = 0;
        preciocomb = 155.9; //pesos por litro
        VolActual = 0;
        PesoActual = 0;
    }

	~cFurgoneta(){

	}
	
}//end cFurgoneta