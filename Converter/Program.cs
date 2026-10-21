// See https://aka.ms/new-console-template for more information

using Converter;

double temp = 8;
double dist = 10;

double a = Converter.Converter.CelToFahr(temp);
double b = Converter.Converter.FahrToCel(a);

double c = Converter.Converter.KmToMiles(dist);
// double d = Converter.Converter.MilesToKilometers(c);

Console.WriteLine(a);
Console.WriteLine(b);

Console.WriteLine(c);
// Console.WriteLine(d);