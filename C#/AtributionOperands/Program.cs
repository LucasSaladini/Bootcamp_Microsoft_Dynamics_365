int a = 10;
int b = 20;
int c = a + b;

c = c + 5;
c += 5;
c -= 5;

Console.WriteLine(c + " é o valor das operações da variável c");



int d = Convert.ToInt32("5");
int e = int.Parse("5");

Console.WriteLine(d + " é o valor da variável d");
Console.WriteLine(e + " é o valor da variável e");

int inteiro = 5;
string f = inteiro.ToString();

Console.WriteLine(f + " é o valor da variável f");

int g = 5;
double h = g;

Console.WriteLine(g + " é o valor da variável h");


double i = 4 / (2 + 2);
Console.WriteLine(i + " é o valor da variável i");

string j = "15-";
int k = 0;

int.TryParse(j, out k);

Console.WriteLine(k + " é o valor da variável k");