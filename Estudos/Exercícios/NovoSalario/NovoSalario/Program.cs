using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aumento de salrio de 15%");
            Console.Write("Digite seu salario atual: ");
            double salario = double.Parse(Console.ReadLine());

            double novoSalario = salario * 0.15;
            
            Console.WriteLine("O seu salario com 15% de Acresimo é " + (novoSalario+salario) + "R$");
            Console.WriteLine("Um acresimo de " + novoSalario + "R$");

            Console.ReadKey();
                
        }
    }
}
