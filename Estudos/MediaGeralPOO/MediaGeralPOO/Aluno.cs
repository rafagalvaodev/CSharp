using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Aluno
    {
        public String nome { get; private set; }

        private double[] _notas;

        public Aluno(String nome, int provas)
        {
            this.nome = nome;
            _notas = new double[provas]; 
        }

        public double media
        {
            get
            {
                return calculaMedia();
            }
        }

        public void inserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.Write($"Digite a nota {i + 1}: ");
                _notas[i] = double.Parse(Console.ReadLine());

            }
        }


        private double calculaMedia()
        {

            double total = 0;

            for(int i = 0; i < _notas.Length; i++)
            {
                total += _notas[i];
            }

            return total/ _notas.Length;

        }




    }
}
