using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinheiroNaCarteira
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veja quantos dolares voce pode comprar");

            Console.Write("Digite o valor em reais que voce tem na carteira: ");
            double carteira = double.Parse(Console.ReadLine());

            double dolares = carteira / 4.87;

            dolares = Math.C(dolares ,2);

            Console.WriteLine("Voce pode comprar " + dolares + "$, Com os seus " + carteira + "R$ ");

            Console.ReadKey();


        }
    }
}
