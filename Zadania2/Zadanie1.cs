using System;

internal partial class Program
{
    private static void Zadanie1(string[] args)
    {
        Console.Write("Podaj temperature w stopniach Celsjusza: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("Temperatura w stopniach Fahrenheita: {0,2:F2}", 32 + 9d / 5 * c);
        Console.ReadKey();
    }
}