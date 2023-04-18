using MathOperators.Models;

Calculator calc = new Calculator();

calc.Sum(10, 30);
calc.Subtract(10, 50);
calc.Multiply(15, 45);
calc.Division(2, 2);
calc.Power(3, 3);
calc.Sin(30);
calc.Cos(30);
calc.Tan(30);

int numberIncrement = 10;
int numberDecrement = 20;

Console.WriteLine(numberIncrement);
Console.WriteLine("Incrementando o 10");
numberIncrement++;
Console.WriteLine(numberIncrement);
Console.WriteLine(numberDecrement);
Console.WriteLine("Decrementando o 20");
numberDecrement--;
Console.WriteLine(numberDecrement);