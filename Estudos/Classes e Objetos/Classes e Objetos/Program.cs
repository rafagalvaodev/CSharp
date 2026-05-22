using Classes_e_Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinhaClasse person = new MinhaClasse();

            person.setNome("Pedro");

            Console.WriteLine(person.getNome());

            StringBuilder mensagem = new StringBuilder();

            mensagem.Append("O nome é " + person.getNome());

            String dizer = mensagem.ToString();


            Console.WriteLine(dizer);
            Console.ReadKey();
        }
    }
}
