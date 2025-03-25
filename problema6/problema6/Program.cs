using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, p;
            Console.WriteLine("ingrese un numero");
            a= int.Parse(Console.ReadLine());
            p = a * a * a;
            Console.WriteLine("La potencia de "+a+ " elevado al cubo es: " +p);
            Console.ReadKey();

        }
    }
}
