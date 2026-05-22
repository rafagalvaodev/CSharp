using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Matematica
    {
        public void somar(int numero1, int numero2)
        {
            Console.WriteLine("A soma entre " + numero1 + " e " + numero2 + " é igual a " + (numero1 + numero2));
        }

        public void subtrair(int numero1 , int numero2)
        {
            Console.WriteLine("A subtração entre " + numero1 + " e " + numero2 + " é Igual a " + (numero1 - numero2));
        }

        public void multiplicar(int numero1, int numero2)
        {
            Console.WriteLine("A multiplicação entre " + numero1 + " e " + numero2 + " é Igual a " + (numero1 * numero2));
        }

        public void dividir(int numero1, int numero2)
        {
            Console.WriteLine("A divisão entre " + numero1 + " e " + numero2 + " é Igual a " + (numero1 / numero2));
        }





    }
}
