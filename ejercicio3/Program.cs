﻿using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una casa de video juegos otorga un descuento dependiendo del importe 
            //de la compra realizada según los siguientes valores:
            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18%.

            float importe;
             

            Console.WriteLine("Ingrese un Valor");
            importe = float.Parse(Console.ReadLine());

            if(importe >= 1000){
                if(importe < 5000)
                    importe = importe * 0.82F;

                else
                    importe = importe * 0.90F;
                
            }                 
            Console.WriteLine("El importe final es: " + importe);



        }
    }
}
