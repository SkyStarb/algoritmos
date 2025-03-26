using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("digite un numero:");
            n=int.Parse(Console.ReadLine());
            if (n % 2 == 0) 
            {
                Console.WriteLine(+n + " es par");
            }
            else
            {
                Console.WriteLine(n+ " es impar"); 
            }
            Console.ReadKey();
        }
    }
}
