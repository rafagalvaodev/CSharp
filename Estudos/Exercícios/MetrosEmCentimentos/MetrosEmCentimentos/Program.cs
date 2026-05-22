using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrosEmCentimentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converso de metros em centímetros");
            Console.Write("Digite um valor em metros: ");
            double metros = double.Parse(Console.ReadLine());

            double cm = metros * 100;

            Console.WriteLine(metros + "M é igual a " + cm + "Cm");

            Console.ReadKey();

        }
    }
}
