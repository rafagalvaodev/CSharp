using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 2 números e veja sua soma ");
            Console.WriteLine("Digie o Primeiro número: ");
            int Numero_Um = int.Parse(Console.ReadLine());
            Console.WriteLine("Digie o Segundo número: ");
            int Numero_Dois = int.Parse(Console.ReadLine());
            int soma = Numero_Um + Numero_Dois;
            Console.WriteLine("A soma emtre " + Numero_Um + " e " + Numero_Dois + " é igual a " + soma);
            Console.ReadLine();
        }
    }
}
