// See https://aka.ms/new-console-template for more information

DateTime data = DateTime.Now;

while(true){
    Console.Clear();
    Console.WriteLine(data.ToShortTimeString());
    
}

decimal valor = 1320.0m;

long cpf = 12345678901;

Console.WriteLine($"O salário é de {valor:C0}");
Console.WriteLine($"O salário é de {valor.ToString("C")}");
Console.WriteLine($"CPF {cpf.ToString("###.###.###.##")}");



