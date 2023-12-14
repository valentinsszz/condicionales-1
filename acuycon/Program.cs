using System;

namespace acuycon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Acumuladores y contadores 
            int contador = 0, e1 =20 , e2 = 15, e3 = 20;
            int acumulador = 0, promedio;

            if(e1 > 18) {
                contador++;
                acumulador += e1;
            }

            if(e2 > 18) {
                contador++;
                acumulador += e2;
            }

            if(e3 > 18){
                contador++;
                acumulador += e3;
            }
                promedio = acumulador / contador;
                Console.WriteLine("el promedio es: " + promedio);

        }
    }
}
