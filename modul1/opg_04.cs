using System;
/* Opgave 4)
 * Skriv et program som indlæser 2 tal og en regne operator ('+', '-', '*' eller '/'), 
 * hvorefter det udskriver regne operatoren udført på de 2 tal.
 */

public class opg_04
{
    public void Run()
    {
        Console.WriteLine("Indtast det første tal: ");
        double tal1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Indtast det andet tal: ");
        double tal2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Vælg regneoperator: ('+', '-', '*' eller '/')");
        char op = Convert.ToChar(Console.ReadLine());

        double result = 0;

        if (op == '+')
        {
            result = tal1 + tal2;
        }
        else if (op == '-')
        {
            result = tal1 - tal2;
        }
        else if (op == '*')
        {
            result = tal1 * tal2;
        }
        else if (op == '/')
        {
            if (tal1 != 0 && tal2 != 0)
            {
                result = tal1 / tal2;
            }
            else
            {
                Console.WriteLine("man kan ikke dividere med 0 din klaphat!!!");
                return;
            }
        }
        else
        {
            Console.WriteLine("Makker jeg sagde ('+', '-', '*' eller '/')");
        }

        Console.WriteLine($"{tal1} {op} {tal2} = {result}");

    }

}