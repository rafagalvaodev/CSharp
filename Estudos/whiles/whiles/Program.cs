using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            Console.WriteLine("Digite sua idade e veja algo legal");
            Console.Write("Digite aqui sua idade: ");
            byte idade = byte.Parse(Console.ReadLine());

            if(idade >= 18+1)
            {
                Console.WriteLine("Voce é de maior " + idade);
            }
            else
            {
                Console.WriteLine("Não é de maior");
            }


/*
                Console.WriteLine("O valor é "+ (valor+1) );
                ++valor;
                if (valor == 102)
                {
                    while(valor > 0)
                    {
                        Console.WriteLine("O valor é " + (valor - 1));
                        --valor;
                    }
                }*/

            Console.ReadKey();
        }
    }
}
