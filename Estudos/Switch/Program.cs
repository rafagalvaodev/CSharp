using System.ComponentModel;
using System.Diagnostics;

Console.WriteLine("Switch case");

Console.Write("Digite um valor: ");
int valor = Convert.ToInt32(Console.ReadLine());

switch (valor)
{
    case 0:    
        Console.Write($"Tente um número maior que {valor}");
        break;
    case 8:
        Console.WriteLine($"Tabuada de {valor}");
        for(int h = 1; h <= 10; h++)
        {
            Console.WriteLine($"{valor} X {h} = {valor*h}");
        }
        break;
    case 29:
        
        int newValor = valor * 2;
        Console.WriteLine(newValor);
        break;
    default:
        Console.Write($"Valor digitado foi {valor}");
        break;        
}