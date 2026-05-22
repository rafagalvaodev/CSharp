using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inteiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O número inteiro de uma fração");

            Console.Write("Digite um número qualquer: ");
            double valor = double.Parse(Console.ReadLine());

            int resultado = (int) Math.Round(valor);

            Console.WriteLine("O inteiro do número " + valor + " é " + resultado);

            Console.ReadKey();
        }
    }
}
