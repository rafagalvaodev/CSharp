using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número e veja sua tabuada");
            Console.Write("Digite qualquer valor: ");
            int numero = int.Parse(Console.ReadLine());

            for(int i = 1;  i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " é igual a " + numero*i);
            }

            Console.ReadKey();

        }
    }
}
