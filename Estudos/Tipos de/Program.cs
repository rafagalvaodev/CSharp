using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_Primitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite algo");
            var variavel = Console.ReadLine();
            Console.WriteLine(variavel.GetType());
            Console.WriteLine(variavel.GetHashCode());
            Console.WriteLine(variavel.GetTypeCode());
            Console.ReadLine();
        }
    }
}
