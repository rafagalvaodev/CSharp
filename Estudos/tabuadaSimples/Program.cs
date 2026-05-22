Console.WriteLine(" Tabuadas ");
Console.Write("Digite um número para ver sua tabuada: ");
double valor = Convert.ToDouble(Console.ReadLine());
Console.Write($"Digite até onde quer ver a tabuada de {valor}:  ");
int ate = Convert.ToInt32(Console.ReadLine());
for(int contador = 1; contador <= ate; contador++ )
{
    Console.WriteLine($"A tabuda de {valor} X {contador} = {valor*contador}");
    if(contador == ate)
    {
        Console.WriteLine("Chegou ao fim");
    } 
} 
