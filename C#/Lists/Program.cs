List<string> listString = new List<string>();

listString.Add("SP");
listString.Add("BH");
listString.Add("MG");

Console.WriteLine("Percorrendo a lista com FOR");
for (int counter = 0; counter < listString.Count; counter++)
{
    Console.WriteLine($"Posição Número {counter} - {listString[counter]}");
}

int counterForeach = 0;

Console.WriteLine("Percorrendo a lista com FOREACH");
foreach (string item in listString)
{
    Console.WriteLine($"Posição Número {counterForeach} - {item}");
    counterForeach++;
}