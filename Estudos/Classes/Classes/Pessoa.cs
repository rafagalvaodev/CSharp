using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Pessoa
    {
        public String nome;
        public int idade;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }

        public void Apresentar(String nome, int idade)
        {
            StringBuilder mensagem = new StringBuilder();

            mensagem.Append("Olá, meu nome é ");
            mensagem.Append(nome);
            mensagem.Append(" e tenho ");
            mensagem.Append(idade);
            mensagem.Append(" anos");
            Console.WriteLine(mensagem);
        }


    }
}
