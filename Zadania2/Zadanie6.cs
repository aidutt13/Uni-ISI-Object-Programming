using System;

internal partial class Program
{
    static void Zadanie6(string[] args)
    {
        int x, y = 4;
        x = (y -= 2);
        x = y++;
        x = y--;

        Console.WriteLine($"x: {x}; y: {y}");
        Console.ReadKey();
    }

}
}