using System;
namespace modul1;

public class Opgave1
{
    public void Run()
    {
        Console.Write("indtast et tal: ");
        double tal1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("indtast tal 2: ");
        double tal2 = Convert.ToDouble(Console.ReadLine());

        double sum = tal1 + tal2;
        Console.WriteLine($"summen af {tal1} og {tal2} er: {sum}");
        // eller
        Console.WriteLine("\nSummen af " + tal1 + " og " + tal2 + " er: " + sum);
    }
}