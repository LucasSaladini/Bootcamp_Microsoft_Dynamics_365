using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal monetaryValue = 1582.40M;

Console.WriteLine($"{monetaryValue:C}"); //:C -> Currency
Console.WriteLine(monetaryValue.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(monetaryValue.ToString("C8"));


double percent = .3421;

Console.WriteLine(percent.ToString("P2"));

int number = 123456;

Console.WriteLine(number.ToString("##-##-##"));





//DateTime
DateTime date = DateTime.Now;
Console.WriteLine($"Hora atual: {date}");
Console.WriteLine($"Hora Personalizada: {date.ToString("MM/dd/yyyy HH:mm")}");
Console.WriteLine($"Apenas data: {date.ToShortDateString()}");
Console.WriteLine($"Apenas hora: {date.ToShortTimeString()}");

DateTime parsedDate = DateTime.Parse("17/04/2022 18:00");
Console.WriteLine($"Data parsed: {parsedDate}");