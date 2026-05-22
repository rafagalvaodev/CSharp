using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int data = DateTime.Now.Day;
            Inicio:
            Console.Write("Digite a o dia do seu aniversario: ");
            int aniversario = int.Parse(Console.ReadLine());

            if (data == aniversario)
            {
                Console.WriteLine("Feliz aniversario: ");
            }else if(aniversario == 0)
            {
                Console.WriteLine("Imposivel sua data de nascimento ser 0");
                goto Inicio;
            }else
            {
                Console.WriteLine("Ainda não é seu aniversario ");
                goto Inicio;
            }

            Console.ReadKey();
        }
    }
}
