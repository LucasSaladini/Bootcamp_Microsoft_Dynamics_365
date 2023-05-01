using ExceptionsAndCollections.Models;

try
{
    string[] lines = File.ReadAllLines("files/read_file.txt");

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui"); //Sempre é executado (com ou sem erro)
}

//Using Models Exception
new ExceptionExample().Method1();