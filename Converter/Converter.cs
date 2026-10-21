namespace Converter;

public class Converter
{
    public static double CelToFahr(double x)
    {
        return x * 9 / 5 + 32;
    }
    public static double FahrToCel(double x)
    {
        return (x - 32) / 1.8;
    }
    // public static double CelToFahr(double x)
    // {
    //     return x * 9 / 5 + 32;
    // }
    // public static double CelToFahr(double x)
    // {
    //     return x * 9 / 5 + 32;
    // }
}