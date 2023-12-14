using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números
            //distintos y luego mostrar por pantalla el menor de ellos.

            int a, b, c, d, minimo;

            Console.WriteLine("ingrese el primer numero");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("ingrese el tercer numero");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto numero");
            d = int.Parse(Console.ReadLine());


            if(a < b)
                minimo = a;
                else{minimo = b;}
                
            if(c < minimo)
                minimo = c;
                
            if(d < minimo)
                minimo = d;
                
            Console.WriteLine("El minimo es:" + minimo);

        }
    }
}
