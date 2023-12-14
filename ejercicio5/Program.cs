using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números 
            //y luego mostrar por pantalla cuáles son mayores a 100

            int a, b, c, d;

            Console.WriteLine("Ingrese un numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un otro: ");
            d = int.Parse(Console.ReadLine());

            if(a > 100) 
            Console.WriteLine("El primer valor " + a + " es mayor a 100");
            if (b > 100)  
            Console.WriteLine("El segundo valor " + b + " es mayor a 100");
             if(c > 100) 
            Console.WriteLine("El tercer valor " + c + " es mayor a 100");
            if (d > 100)  
            Console.WriteLine("El cuarto valor " + d + " es mayor a 100");

        }
    }
}
