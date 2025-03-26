using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema8
{
    class Program
    {
        static void Main(string[] args) 
        {
            int n;
            Console.Write("ingrese un digito:");
            n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                n = (-1) * n;
            }
            Console.WriteLine("el valor absoluto es: " + n);
            Console.ReadKey();

        }
    }
}
