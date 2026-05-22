using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
            Console.Clear();

            Console.WriteLine("-_-Calculadora-_-");
            Console.Write("Digite o primeiro número: ");
            float numeroUM = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            float numeroDOIS = float.Parse(Console.ReadLine());
            Console.Write("Digite a operação: ");
            char operacao = char.Parse(Console.ReadLine());

            switch (operacao)
            {
                default:
                    Console.WriteLine("Operação inesistente tente outra vez");
                    break;
                case '+':
                    Console.WriteLine("A operação escolhida foi soma");
                    Console.WriteLine("A soma entre " + numeroUM + " e " + numeroDOIS + " é " + (numeroUM + numeroDOIS));
                    break;
                case '-':
                    Console.WriteLine("A operação escolhida foi subtração");
                    Console.WriteLine("A subtração entre " + numeroUM + " e " + numeroDOIS + " é " + (numeroUM - numeroDOIS));
                    break;
                case 'x':
                case 'X':
                case '*':
                    Console.WriteLine("A operação escolhida foi multiplicação");
                    Console.WriteLine("A multiplicação entre " + numeroUM + " e " + numeroDOIS + " é " + (numeroUM*numeroDOIS));
                    break;
                case '/':
                    if (numeroUM == 0 || numeroDOIS == 0)
                    {
                        Console.WriteLine("A divisão por 0 é impossível");
                    }
                    else
                    {
                        Console.WriteLine("A operação escolhida foi divisão");
                        Console.WriteLine("A divisão entre " + numeroUM + " e " + numeroDOIS + " é " + (numeroUM / numeroDOIS));

                    }
                    break;
            }

            Console.Write("Deseja fazer outra operação ?");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                goto inicio;
            }
            Console.ReadKey();

        }
    }
}
