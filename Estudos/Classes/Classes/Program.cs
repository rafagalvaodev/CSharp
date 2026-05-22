// See https://aka.ms/new-console-template for more information
using Classes;

Console.WriteLine("Hello, World!");

Pessoa pessoa = new Pessoa();

Console.Write("Digite seu nome: ");
String _nomePessoa = Console.ReadLine();

Console.Write("Digite sua idade: ");
int _idadePessoa = int.Parse(Console.ReadLine());

pessoa.Apresentar(_nomePessoa, _idadePessoa);

