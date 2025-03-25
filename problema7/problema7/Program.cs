using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("ingresa un digito");
            x= int.Parse(Console.ReadLine());
            //y = 4 * x * x - 6 * x + 180;
            y = 4 * (int)Math.Pow(x, 2) - 6 * x + 180;
            Console.WriteLine("El punto es (" + x + " , " +y+ ")");
            Console.ReadKey();
        }
    }
}
