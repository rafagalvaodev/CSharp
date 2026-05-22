using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertendo_Nomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome01, nome02, nome03, nome04, aux;

            Console.Write("Digite o nome N1: ");
            nome01 = Console.ReadLine();

            Console.Write("Digite o nome N2: ");
            nome02 = Console.ReadLine();

            Console.Write("Digite o nome N3: ");
            nome03 = Console.ReadLine();

            Console.Write("Digite o nome N4: ");
            nome04 = Console.ReadLine();


            // Invertendo a ordem das letras dos nomess inseridos.
            Console.WriteLine();
            Console.WriteLine("Veja os nomes Invertidos: ");
            Console.WriteLine(nome01.Reverse().ToArray());
            Console.WriteLine(nome02.Reverse().ToArray());
            Console.WriteLine(nome03.Reverse().ToArray());
            Console.WriteLine(nome04.Reverse().ToArray());



            // Mudando a ordem dos nomes inseidos.

            aux = nome01;
            nome01 = nome04;
            nome04 = aux;
            aux = nome02;
            nome02 = nome03;
            nome03= aux;

            Console.WriteLine();
            Console.WriteLine("Veja os nome em ordem invertida: ");
            Console.WriteLine(nome01);
            Console.WriteLine(nome02);
            Console.WriteLine(nome03);
            Console.WriteLine(nome04);


            Console.ReadKey();


        }
    }
}
