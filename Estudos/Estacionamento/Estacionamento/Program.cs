// See https://aka.ms/new-console-template for more information
List<String> estacionando = new List<String>();

Console.WriteLine("Bem-vindo ao estacionamento DIO");
Console.Write("Digite o valor inicial: ");
decimal valorInicial = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite o valor por hora: ");
decimal valorHora = Convert.ToDecimal(Console.ReadLine());
int contadorVeicular = 0;
while (true)
{
    
    Console.Clear();
    Console.Write("Dejesa adcionar um veiculo ? S/N: ");
    String resposta = Console.ReadLine().ToUpper();
    if(resposta == "S")
    {
        Console.Write("Digite a placa do veiculo: ");

        String placa = Console.ReadLine().ToUpper();
        estacionando.Add(placa);
        contadorVeicular++;
    }
    else
    {
        if (contadorVeicular == 0)
        {
            Console.WriteLine($"Nenhum veículo foi estacionado");
           
        }else if (contadorVeicular ==1 ){
            Console.WriteLine($"{contadorVeicular} veículo foi estacionado ");
        }
        else
        {
            Console.WriteLine($"{contadorVeicular} veículos foram estacionados ");
        }
        
        break;
    }
  
}

Console.WriteLine();

inicio:

Console.WriteLine("Digite 1 para ver todos os veículos estacionados: ");
Console.WriteLine("Digite 2 para remover um veículos: ");
Console.WriteLine("Digite 3 para sair");

Console.WriteLine();
Console.Write("Digite sua opção: ");
String opcao = Console.ReadLine();

Console.Clear();

switch (opcao)
{
    
    case "1":
        foreach (String carros in estacionando)
        {
            Console.WriteLine($"Veículo de placa {carros}");
           
        }
        Console.WriteLine();
        goto inicio;
        break;
    case "2":
       Console.WriteLine("Lista de carros");
        foreach (String carros in estacionando)
        {
            Console.WriteLine($"Veículo de placa {carros}");
        }
        
        Console.Write("Digite a placa do veiculo: ");
        String placa = Console.ReadLine();
        Console.Write("");
        estacionando.Remove(placa);
        Console.WriteLine($"O veiculo de placa {placa} foi removido com sucesso ");

        Console.Write($"Digite quantas horas o veículo de placa {placa} ficou estacionado: ");
        int quantidadeHoras = Convert.ToInt32(Console.ReadLine());

        decimal valorPagar = valorHora * quantidadeHoras + valorInicial;

        Console.WriteLine($"O total ser pago é de {valorPagar}R$ por {quantidadeHoras} Horas");
        Console.WriteLine();

        goto inicio;
        break;
    case "3":
        Console.WriteLine("Até breve");
        break;
}


