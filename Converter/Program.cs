// See https://aka.ms/new-console-template for more information

using System.Data;
using Converter;

// double dist = 10;
// double weight = 57;
// double b = Converter.Converter.FahrToCel();

// double c = Converter.Converter.KmToMiles(dist);
// double d = Converter.Converter.KgToPounds(weight);

// Console.WriteLine(a);
// Console.WriteLine(b);
//
// Console.WriteLine(c);
// Console.WriteLine(d);

while (true)
{
    // Menu
    Console.Clear();
    
    Console.WriteLine("1. Celsius till Fahrenheit");
    Console.WriteLine("2. Fahrenheit till Celsius");
    Console.WriteLine("3. Kilometer till engelska mil");
    Console.WriteLine("4. Kilo till pund");
    Console.WriteLine("5. Lista antal körda ekvationer och avsluta.");
    
    Console.Write("Välj: ");

    string input = Console.ReadLine();
    
    switch (input)
    {
        // CelToFahr
        case "1":
            Console.Write("Värde: ");
            input = Console.ReadLine();
            double x = 0;
            double.TryParse(input, out x);
            double fahr = Converter.Converter.CelToFahr(x);
            
            Console.WriteLine($"{input} grader Celsius är {fahr} grader Fahrenheit.");
            Console.ReadKey();
            
            break;
        
        case "2":
            Console.Write("Värde: ");
            input = Console.ReadLine();
            x = 0;
            Double.TryParse(input, out x);
            double cel = Converter.Converter.FahrToCel(x);
            
            Console.WriteLine($"{input} grader Fahrenheit är {cel} grader Celcius.");
            Console.ReadKey();
            
            break;
        
        case "3":
            Console.Write("Värde: ");
            input = Console.ReadLine();
            x = 0;
            Double.TryParse(input, out x);
            double miles = Converter.Converter.KmToMiles(x);
            
            Console.WriteLine($"{input} km är {miles} engelska mil.");
            Console.ReadKey();
            
            break;
        
        case "4":
            Console.Write("Värde: ");
            input = Console.ReadLine();
            x = 0;
            Double.TryParse(input, out x);
            double pounds = Converter.Converter.KgToPounds(x);
            
            Console.WriteLine($"{input} kilo är {pounds} pund.");
            Console.ReadKey();

            break; 
        case "5":
            Console.WriteLine($"{Converter.Converter.totalEquations} ekvationer har körts. Hej då!");
            Environment.Exit(1);

            break;
        
    }
}