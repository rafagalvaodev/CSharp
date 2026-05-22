using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorando.Models
{
    internal class Pessoa
    {
        private String _nome;
        private sbyte _idade;
        public String nome 
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio ");

                    _nome = value;
                }
            } 
        }
        public sbyte idade 
        {
            get => _idade;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0");

                    _idade = value;
                }
            }
        }

        public void apresentar()
        {
            this.nome = nome;
            this.idade = idade;
            Console.WriteLine($"Olá me chamo {nome} e tenho {idade} anos");
        }
    }
}
