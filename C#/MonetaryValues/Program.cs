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