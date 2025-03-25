using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("digite el valor de a:");
            a= int.Parse(Console.ReadLine());
            Console.WriteLine("digite el valor de b:");
            b= int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("La suma de " +a+ " + " +b +" es: " +c);
            Console.ReadKey();
        }
    }
}
