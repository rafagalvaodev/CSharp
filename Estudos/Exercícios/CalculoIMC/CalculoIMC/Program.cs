using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ||| Calculadora de IMC ||| ");
            Console.Write("Digite seu peso em kilos: ");
            float peso = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite a sua altura em metros: ");
            float altura = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            if (imc < 18.5 )
            {
                Console.WriteLine("Magreza");
            } else if (imc >= 18.5 && imc < 24.9  )
            {
                Console.WriteLine("Normal");
            } else if (imc >= 25 && imc < 29.9)
            {
                Console.WriteLine("Sobrepeso");
            } else if (imc >= 30 && imc < 34.9 )
            {
                Console.WriteLine("Obesidade grau I");
            }else if (imc >= 35 && imc < 39.9)
            {
                Console.WriteLine("Obesidade grau II");
            }
            else
            {
                Console.WriteLine("Obesidade grau III");
            }

            Console.ReadKey();
        }
    }
}
