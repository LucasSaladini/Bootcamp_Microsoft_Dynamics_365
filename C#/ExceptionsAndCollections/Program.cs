try
{
    string[] lines = File.ReadAllLines("files/readfile.txt");

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}