// See https://aka.ms/new-console-template for more information
int[] numeros = new int[5];

numeros[0] = 72;
numeros[1] = 64;
numeros[2] = 50;
numeros[3] = 7;
numeros[4] = 8;

foreach( int numero in numeros)
{
    Console.WriteLine(numero);
}

for(int contador = 0; contador < numeros.Length; contador++)
{
    Console.WriteLine($"O número {contador+1} é {numeros[contador]} ");

}


