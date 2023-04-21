int[] arrayIntegers = new int[3];

arrayIntegers[0] = 72;
arrayIntegers[1] = 74;
arrayIntegers[2] = 50;

for (int counter = 0; counter < arrayIntegers.Length; counter++)
{
    Console.WriteLine($"Posição Número {counter} - {arrayIntegers[counter]}");
}