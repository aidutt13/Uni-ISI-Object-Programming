using System;

internal partial class Program
{
    private static void Zadanie3(string[] args)
    {
        Console.Write("Podaj wage (kg): ");
        double w = double.Parse(Console.ReadLine());
        Console.Write("Podaj wzrost (m): ");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("BMI: {0,2:F1}", w / (h * h));
        Console.ReadKey();
    }
}