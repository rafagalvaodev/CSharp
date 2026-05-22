
int a = 1;
Console.WriteLine("loopings com WHILE");
while (a <= 10)
{
    if (a % 2 == 1)
    {
        a++;
        continue;
    }
    Console.WriteLine("A tabuada de 6" + "X" + a + " = " + (a * 6));
    a++;
   
}
Console.WriteLine("loopings com FOR");
for (int b = 1; b <= 10; b++)
{
    Console.WriteLine("A tabuada de 6" + "X" + b + " é igual a " + (b * 6));

}
Console.WriteLine("loopings com DO-WHILE");
int c = 1;
do
{
    Console.WriteLine("A tabuada de 6" + "X" + c + " = " + (c * 6));
    c++;
} while (c <= 10);
