/* Opgave 1)
 * 
 * Skriv et program som indlæser 2 tal og udskriver summen.
 */

public class opg_01
{
    public void Run()
    {
        Console.WriteLine("Indtast det første tal: ");
        double tal1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Indtast det næste tal: ");
        double tal2 = Convert.ToDouble(Console.ReadLine());

        double sum = tal1 + tal2;

        Console.WriteLine($"Summen af tallet {tal1} og tallet {tal2} er: {sum}.");

    }
    
}