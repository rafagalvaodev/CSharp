static void LerArquivo(String nomeArquivos)
{   
    using(StreamReader arquivos = File.OpenText(nomeArquivos))
    {
        string line;
        while((line = arquivos.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}

LerArquivo(@"C:\Users\rafag\OneDrive\Área de Trabalho\Logica de programação.txt");