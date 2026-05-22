using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programação_Funcional
{
    internal class Program
    {
        public const int NUMERO4 = 0;
        public const int NUMERO1 = 1;
        public const int NUMERO2 = 2;
        public const int NUMERO3 = 3;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Olá, " + name);
            }
        }
    }
}
