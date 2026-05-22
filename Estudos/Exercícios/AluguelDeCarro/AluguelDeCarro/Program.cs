using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelDeCarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanto voce irá pagar pelo aluguel do carro");
            Console.Write("Digite quantos quilometros viajo com o carro: ");
            double km = double.Parse(Console.ReadLine());

            Console.Write("Digite quantos dias ficou com o carro: ");
            int dias = int.Parse(Console.ReadLine());

            double resultado = (km * 0.15) + (dias * 60);
            
            resultado = Math.Round(resultado, 2);

            Console.WriteLine("O valor a pagar por " + dias + " Dias e " + km + "Km" + " é " + resultado + "R$");

            Console.ReadKey();
        }
    }
}
