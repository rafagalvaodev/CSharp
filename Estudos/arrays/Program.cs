int[] list = new int[3];
list[0] = 3;
list[1] = 1;
list[2] = 2;
Console.WriteLine(list);
Console.WriteLine(list[0]);
Console.WriteLine(list.Length-1);
Console.WriteLine(list.Count());

Array.Sort(list);
foreach(int i in list)
{
    Console.WriteLine("O valor é " + i);
}
Console.WriteLine("============/===========" );
List<int> list2 = new List<int>();
list2.Add(3);
list2.Add(1);
list2.Add(4);
list2.Add(2);
Console.WriteLine(list2);
Console.WriteLine(list2.Count());
list2.Sort();
foreach(int i in list2)
{
    Console.WriteLine("O valor é " + i);
}
Console.WriteLine("============/===========");

if (list2.Exists( e => e == 2))
{
    Console.WriteLine("Existe o 2");
}