using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0, b = 10; a < 10; a++, b-- )
            {
                Console.WriteLine( "O valor de a "+ a + " e o valor de " + b + " A soma entre eles é " + (a+b) );
            }

            Console.ReadKey();
        }
    }
}
