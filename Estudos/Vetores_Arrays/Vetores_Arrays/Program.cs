using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int []valores = new int[5];

            valores[0] = 10;
            valores[1] = 20;
            valores[2] = 30;
            valores[3] = 40;
            valores[4] = 50;
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Na posição " + (i+1) + " temos o valor " + valores[i]);
            }

            Console.ReadKey();
        }
    }
}
