using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelDIO.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public string nomeCompleto => $"{Nome} {SobreNome}";

        public Pessoa() { }

        public Pessoa(String nome)
        {
            Nome = nome;
        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            SobreNome = sobrenome;
        }

    }



}