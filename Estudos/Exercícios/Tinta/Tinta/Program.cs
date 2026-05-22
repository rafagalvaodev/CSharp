using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descubra quantas litros de tinta vai precisar para pintar sua parede");
            Console.Write("Digite a altura da parede em metros: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Digite a largura da parede em metros: ");
            double largura = double.Parse(Console.ReadLine());

            double resultado = altura * largura / 2;

            Console.WriteLine("Será necessario " + resultado + " Litros de tinta");


            Console.ReadKey();
        }
    }
}
