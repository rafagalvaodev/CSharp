using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucessor_e_Antecessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digie um número e veja seu sucessor e seu antecessor ");
            Console.WriteLine("Digite Qualquer Valor inteiro");
            int numero = int.Parse(Console.ReadLine());
            var sucessor = numero + 1;
            var antecessor = numero - 1;
            Console.WriteLine("O Antecessor de " + numero + " é " + antecessor);
            Console.WriteLine("O Sucesor de " + numero + " é " + sucessor);
            Console.ReadLine();

        }
    }
}
