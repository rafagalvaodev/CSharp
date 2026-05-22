using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobroTriploRaiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número e veja Seu dobro, triblo e sua raiz quadada: ");

            Console.Write("Digite qualquer valor: ");
            Double valor = Double.Parse(Console.ReadLine());

            Console.WriteLine("O dobro de " + valor + " é igual a " + (valor * 2));
            Console.WriteLine("O triplo de " + valor + " é igual a " + (valor * 3));
            Console.WriteLine("A raiz quadrada de " + valor + " é igual a " + (Math.Sqrt(valor)));

            Console.ReadKey();
        }
    }
}
