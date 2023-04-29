string[] lines = File.ReadAllLines("files/read_file.txt");

foreach (string line in lines)
{
    Console.WriteLine(line);
}