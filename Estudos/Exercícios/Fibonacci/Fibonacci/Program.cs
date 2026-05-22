using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1 , c = 0;
            Console.WriteLine(">_> Sequencia de Fibonacci <_< ");
            Console.Write("Digite um número qualquer: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("A sequencia de Fibonacci com " + numero + " Valores");
            
            for(int i = 0; i < numero; i++) 
            {
                if ( i < numero - 1)
                {
                    Console.Write(a + " X ");
                }
                else
                {
                    Console.WriteLine(a);
                }

                c = a + b;
                a = b;
                b = c;
            }



            Console.ReadKey();
        }
    }
}
