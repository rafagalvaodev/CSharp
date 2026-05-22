using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstração.models
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public void apresentar(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Console.WriteLine($"Olá meu nome é {nome} e tenho {idade}");
        }
    }
}