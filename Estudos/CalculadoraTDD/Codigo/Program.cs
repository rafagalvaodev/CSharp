

using Codigo;

Calculadora _calculando = new Calculadora();

Console.WriteLine(_calculando.Somar(1,2));
Console.WriteLine(_calculando.Dividir(0,2));
Console.WriteLine(_calculando.Mutiplicar(3,2));
Console.WriteLine(_calculando.Subtrair(10,2));

Console.WriteLine(_calculando.ListaHistorico);