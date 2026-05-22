// See https://aka.ms/new-console-template for more infor
List<int> listaNumeros = new List<int>();

listaNumeros.Add(10);
listaNumeros.Add(50);
listaNumeros.Add(42);
listaNumeros.Add(5);

Console.WriteLine(listaNumeros);

int numeroContador = 0;
foreach(int numero in listaNumeros)
{
    Console.WriteLine($"O {numeroContador+1} número é {numero}");
    numeroContador++;
       
}
    Console.WriteLine();
for (int contador = 0; contador < listaNumeros.Count; contador++)
{
    Console.WriteLine($"O {contador + 1} número é {listaNumeros[contador]} ");
}