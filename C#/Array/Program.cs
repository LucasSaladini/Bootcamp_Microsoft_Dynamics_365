int[] arrayIntegers = new int[3];

arrayIntegers[0] = 72;
arrayIntegers[1] = 74;
arrayIntegers[2] = 50;

Array.Resize(ref arrayIntegers, arrayIntegers.Length * 2);

Console.WriteLine("Percorrendo o Array com o FOR");
for (int counter = 0; counter < arrayIntegers.Length; counter++)
{
    Console.WriteLine($"Posição Número {counter} - {arrayIntegers[counter]}");
}

Console.WriteLine("Percorrendo o Array com o FOREACH");

int counterForeach = 0;
foreach (int value in arrayIntegers)
{
    Console.WriteLine($"Posição Número {counterForeach} - {value}");
    counterForeach++;
}