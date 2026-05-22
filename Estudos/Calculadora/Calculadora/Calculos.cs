using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculos
    {
        public void subtrair(int numeroOne, int numeroTwo)
        {
            if (numeroOne < numeroTwo)
            {
                Console.WriteLine("O primeiro valor deve ser maior que o segundo");
            }
            else
            {
                Console.WriteLine($"A subtração entre {numeroOne} e {numeroTwo} é igual a {numeroOne - numeroTwo}");
            }
        }

        public void somar(int numeroOne, int numeroTwo)
        {
            Console.WriteLine($"A soma entre {numeroOne} e {numeroTwo} é igual a {numeroOne + numeroTwo}");
        }

        public void multiplicar(int numeroOne, int numeroTwo)
        {
            Console.WriteLine($"A multiplicação entre {numeroOne} e {numeroTwo} é igual a {numeroOne * numeroTwo}");
        }

        public void dividir(int numeroOne, int numeroTwo)
        {
            if(numeroOne == 0 || numeroTwo == 0)
            {
                Console.WriteLine("A divisão por zero é impossivel");

            } else if(numeroOne < numeroTwo)
            {
                Console.WriteLine("O primeiro valor deve ser maior que o segundo");
            }
            else
            {
                Console.WriteLine($"A divisão entre {numeroOne} e {numeroTwo} é igual a {numeroOne / numeroTwo}");
            }
        }

        public void potencia(int numeroOne, int numeroTwo)
        {
            double potencia = Math.Pow(numeroOne, numeroTwo);
            Console.WriteLine($"A pontenciação entre {numeroOne} e {numeroTwo} é igual a {potencia}");
        }
    }
}
