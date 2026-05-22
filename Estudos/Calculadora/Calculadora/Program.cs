// See https://aka.ms/new-console-template for more information
using Calculadora;


Calculos calculadora = new Calculos();

calculadora.subtrair(7, 9);
calculadora.subtrair(9, 7);
calculadora.somar(3, 5);
calculadora.multiplicar(2, 10);
Console.WriteLine();
calculadora.dividir(0, 3);
calculadora.dividir(7, 0);
calculadora.dividir(20, 2);
Console.WriteLine();
calculadora.potencia(5, 2);