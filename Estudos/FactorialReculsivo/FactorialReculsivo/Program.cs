using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialReculsivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial fac = new Factorial();

            Console.Write("Calcular o fatorial de qual número? ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"O fatorial de {numero} é {fac.calculaFatorial(numero)}");

            Console.ReadKey();

        }
    }
}
