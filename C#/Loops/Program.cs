int number = 5;

// for (int counter = 0; counter <= 10; counter++)
// {
//     Console.WriteLine($"{number} x {counter} = {number * counter}");
// }

int counter = 0;

while (counter <= 10)
{
    Console.WriteLine($"{number} x {counter} = {number * counter}");
    counter++;

    if (counter == 6)
    {
        break;
    }
}