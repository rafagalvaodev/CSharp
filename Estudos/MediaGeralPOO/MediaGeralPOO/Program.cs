using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sistemas de notas";


            Console.Write("Digite a quantidade de alunos: ");
            int numeroAlunos = int.Parse(Console.ReadLine());

            Aluno[] alunos = new Aluno[numeroAlunos];



            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write($"Nome do {i+1}º aluno: ");
                String nomeAluno = Console.ReadLine();

                Console.Write($"Quantidade de provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nomeAluno, provas);

                Console.WriteLine($"Digite as notas do aluno {nomeAluno}");
                alunos[i].inserirNotas();
            }

            Console.Clear();

            double mediaGeral = 0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine($"Aluno {aluno.nome}");
                Console.WriteLine($"Média {aluno.media}");

                Console.WriteLine();

                mediaGeral += aluno.media;

            }

            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine($"Média geral dos alunos { Math.Round(resultadoFinal)}");

            Console.ReadKey();
        }
    }
}
