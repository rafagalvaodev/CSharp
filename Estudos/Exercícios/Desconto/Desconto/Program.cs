using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desconto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Produto com desconto");
            Console.Write("Digite o valor do produto: ");
            double valorProduto = double.Parse(Console.ReadLine());

            double desconto = 0.05 * valorProduto;
            Console.WriteLine("O novo valor do produto com o desconto é de " + (valorProduto - desconto));

            Console.ReadKey();
        }
    }
}
