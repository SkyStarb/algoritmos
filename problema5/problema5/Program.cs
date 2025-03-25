using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, Suma, Resta, Multiplicacion, Division;
            Console.WriteLine("Ingrese el valor de a:");
            a= float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b:");
            b= float.Parse(Console.ReadLine());
            Suma = a + b;
            Resta = a - b;
            Multiplicacion = a * b;
            Division = a / b;
            Console.WriteLine("La suma de: " + a + " + " + b + " es: " + Suma + "\n" +
                "La resta de: " + a + " - " + b + " es: " + Resta + "\n" +
                "La multiplicacion de: " + a + " * " + b + " es: " + Multiplicacion + "\n" +
                "La division de: " + a + " / " + b + " es: " + Division + "\n");
            Console.ReadKey();
        }
    }
}
