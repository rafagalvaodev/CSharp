using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOREACH_s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string []listaNOMES = { "Juão", "Pedro", "Lucas", "Luan", "Naldo" };

            foreach( string nome in listaNOMES) 
            {
                if(nome == "Naldo")
                {
                    Console.WriteLine(nome);
                } else if (nome == "Pedro")
                {
                    Console.WriteLine("Olá " + nome);
                }
            }

            Console.ReadKey();
        }
    }
}
