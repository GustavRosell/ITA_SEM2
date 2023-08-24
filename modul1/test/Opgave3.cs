using System;
namespace modul1;

/*
 * Skriv et program som indlæser et tal og derefter udskriver summen af tallene fra 1 og op til og med tallet. 
 * 
 * Så fx på input 5, skal programmet udskrive 1+2+3+4+5 = 15.
 */

public class Opgave3
{
    public void Run()
    {
        Console.WriteLine("indtast et tal: ");
        int tal = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        string equation = "";

        for (int i = 1; i <= tal; i++)
        {
            sum += i;
            equation += i;

            if (i < tal)
            {
                equation += "+";
            }

        }
        Console.WriteLine($"{equation} = {sum}");
    }
}