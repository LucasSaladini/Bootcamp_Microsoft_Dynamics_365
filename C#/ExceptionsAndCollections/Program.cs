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

//Fila - Queue
Queue<int> queue = new Queue<int>();

queue.Enqueue(2);
queue.Enqueue(4);
queue.Enqueue(6);
queue.Enqueue(8);

foreach (int item in queue)
{
    Console.WriteLine($"Itens da fila {item}");
}

Console.WriteLine($"Removento o elemento: {queue.Dequeue()}"); //Remove sempre o primeiro elemento
queue.Enqueue(10);

foreach (int item in queue)
{
    Console.WriteLine(item);
}

//Pilha - Stack
Stack<int> stack = new Stack<int>();

stack.Push(4);
stack.Push(6);
stack.Push(8);
stack.Push(10);

foreach (int item in stack)
{
    Console.WriteLine($"Itens da pilha: {item}");
}

Console.WriteLine($"Removendo o elemento do topo: {stack.Pop()}");

stack.Push(20);

foreach (int item in stack)
{
    Console.WriteLine($"Itens da pilha:  {item}");
}

//Dictionary
Dictionary<string, string> states = new Dictionary<string, string>(); //Primeiro elemento é a chave e o segundo o valor

states.Add("SP", "São Paulo");
states.Add("BA", "Bahia");
states.Add("MG", "Minas Gerais");

foreach (KeyValuePair<string, string> item in states)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}