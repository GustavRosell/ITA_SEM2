using System;
namespace modul1;

public class Opgave2
{
    public void Run()
    {
        Console.WriteLine("Indtast et tal: ");
        int tal = Convert.ToInt32(Console.ReadLine());

        if (tal % 2 == 0)
        {
            Console.Write("Tallet er lige");
        } else
        {
            Console.Write("tallet er ulige");
        }
    }
}