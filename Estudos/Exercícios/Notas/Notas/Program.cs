using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as notas do aluno");

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = nota1 + nota2 / 2;

            Console.WriteLine("A média é " + media);

            Console.ReadKey();
        }
    }
}
