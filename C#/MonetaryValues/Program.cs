using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal monetaryValue = 1582.40M;

Console.WriteLine($"{monetaryValue:C}"); //:C -> Currency
Console.WriteLine(monetaryValue.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(monetaryValue.ToString("C8"));
