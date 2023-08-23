using System;

namespace modul1;

/*
 * Skriv et program som indlæser 2 tal og en regne operator ('+', '-', '*' eller '/'),
 * hvorefter det udskriver regne operatoren udført på de 2 tal.
 */

public class Opgave4
{
    public void Run()
    {
        Console.WriteLine("Indtast det første tal: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Indtast det andet tal: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Indtast regneoperatoren (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        double result = 0;

        if (op == '+')
        {
            result = num1 + num2;
        }
        else if (op == '-')
        {
            result = num1 - num2;
        }
        else if (op == '*')
        {
            result = num1 * num2;
        }
        else if (op == '/')
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Kan ikke dividere med 0.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Ugyldig regneoperator.");
            return;
        }

        Console.WriteLine($"{num1} {op} {num2} = {result}");
    }
}