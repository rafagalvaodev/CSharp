using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boas_Vindas_2_easter_egg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Easter_Egg = "Bolinho";
            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();
            if(name == Easter_Egg)
            {
                Console.WriteLine("Olá, " + name);
                Console.WriteLine("Voce achou o nome ou olhou no codigo?");

            }
            else
            {
                Console.WriteLine("Olá, " + name + " Seja Bem-Vindo(a). ");
            }
            
            Console.ReadLine();
        }
    }
}
