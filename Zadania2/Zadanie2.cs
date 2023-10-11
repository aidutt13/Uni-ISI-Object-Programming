using System;

internal partial class Program
{
    private static void Zadanie2(string[] args)
    {
        Console.Write("Podaj a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Podaj b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Podaj c: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("Delta: {0,2:F4}", b * b - 4 * a * c);
        Console.ReadKey();
    }
}