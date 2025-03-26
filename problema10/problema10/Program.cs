using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("digite el primer numero:");
            n1= int.Parse(Console.ReadLine());
            Console.WriteLine("digite el segundo numero:");
            n2= int.Parse(Console.ReadLine());
            if (n1 >= n2)
            {
                if (n1 == n2) 
                {
                    Console.WriteLine(n1 + " es igual a " + n2);
                }
                else
                {
                    Console.WriteLine(n1 + " es mayor a " + n2);
                }
            }
            else
            {
                Console.WriteLine(n2 + " es mayor a " + n1);
            }
            Console.ReadKey();
        }
    }
}
