using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        delegate void Operacao(int numero1, int numero2);

        static void Main(string[] args)
        {
            Matematica mate = new Matematica();
            int data = DateTime.Now.Day;

            Operacao operacao = null;
            operacao += mate.multiplicar;
            operacao += mate.somar;
            operacao += mate.dividir;
            operacao += mate.subtrair;

            operacao(28, 10);

            Console.WriteLine(data);



            Console.ReadKey();

        }
    }
}
