﻿using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar un número y 
            //luego se emita por pantalla un cartel aclaratorio 
            //si “Es mayor a 10” o “No es mayor a 10”.
            
            int n1;

            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());

            if(n1 > 10) {
                Console.WriteLine("Es mayor a 10");
            }else{
                    Console.WriteLine("No es mayor a 10");
                } 
            

            
        }
    }
}
