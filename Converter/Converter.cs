namespace Converter;

public class Converter
{
    public static int totalEquations { get; private set; }
    public static double CelToFahr(double x)
    {
        totalEquations++;
        return x * 9 / 5 + 32;
    }
    public static double FahrToCel(double x)
    {
        totalEquations++;
        return (x - 32) / 1.8;
    }
    public static double KmToMiles(double x)
    {
        totalEquations++;
        return x * 0.621371;
    }
    public static double KgToPounds(double x)
    {
        totalEquations++;
        return x * 2.20462;
    }
}