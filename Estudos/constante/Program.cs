using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constante
{
    internal class Program
    {
        public const int NUMERO = 8;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());
            if (valor == 0)
            {
                Console.WriteLine("Tente outro número bobão");
            }
            else
            {
                for (int n = 0; n <= 100; n++)
                {
                    Console.WriteLine("A tabuada de " + valor + " X " + n + " = " + (valor * n));
                }
                Console.WriteLine("Somando valores");
                Console.WriteLine(NUMERO + " + " + valor + " = " + (valor + NUMERO));
            }

            Console.Read();
        }
        
        

    }
    
}
