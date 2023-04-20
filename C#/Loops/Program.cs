// int number = 5;

// for (int counter = 0; counter <= 10; counter++)
// {
//     Console.WriteLine($"{number} x {counter} = {number * counter}");
// }

// int counter = 0;

// while (counter <= 10)
// {
//     Console.WriteLine($"{number} x {counter} = {number * counter}");
//     counter++;

//     if (counter == 6)
//     {
//         break;
//     }
// }

// int sum = 0, number = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");

//     number = Convert.ToInt32(Console.ReadLine());

//     sum += number;
// } while (number != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {sum}");

string option;
bool showMenu = true;

while (showMenu)
{
    // Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            showMenu = false;
            // Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

Console.WriteLine("O programa se encerrou");