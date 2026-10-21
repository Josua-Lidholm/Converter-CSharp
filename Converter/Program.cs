// See https://aka.ms/new-console-template for more information

using Converter;

double temp = 8;

double x = Converter.Converter.CelToFahr(temp);
double y = Converter.Converter.FahrToCel(x);

Console.WriteLine(x);
Console.WriteLine(y);