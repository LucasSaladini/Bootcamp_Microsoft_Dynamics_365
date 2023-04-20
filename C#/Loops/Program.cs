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

int sum = 0, number = 0;

do
{
    Console.WriteLine("Digite um número (0 para parar)");

    number = Convert.ToInt32(Console.ReadLine());

    sum += number;
} while (number != 0);

Console.WriteLine($"Total da soma dos números digitados é: {sum}");