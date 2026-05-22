using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comentando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Usei o Console Write para escrever na tela/console 
            Console.WriteLine("Digite um número e veja sua tabuada");

            /*
             * 
             * Usei o Console Read para pegar o valor digitado pelo usuario 
             * Usei a função parse para transformar o valor digitado com string para inteiro 
             * 
             */
            sbyte numero = sbyte.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("Digite até que número a tabuada deve ir");
                int quantidade = int.Parse(Console.ReadLine());
                for (int i = 1; i <= quantidade; i++)
                {
                    Console.WriteLine("A tabuada de " + numero + " X " + i + " é " + (numero * i));
                }
                Console.ReadKey();
                Console.ReadLine();

            }
            catch 
            {

                if (numero < -128 || numero > 127)
                {
                    Console.WriteLine("Digite um número valido: ");
                }
            }
           
            
        }
    }
}
