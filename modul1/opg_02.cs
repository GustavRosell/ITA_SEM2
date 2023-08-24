/* Opgave 2)
 * 
 * Skriv et program som indlæser et tal og udskriver om tallet er lige eller ulige.
 */

public class opg_02
{
    public void Run()
    {
        Console.WriteLine("Indtast et tal: ");
        double tal = Convert.ToDouble(Console.ReadLine());

        if (tal % 2 == 0)
        {
            Console.WriteLine("Tallet er lige");
        }
        else
        {
            Console.WriteLine("Tallet er ulige");
        }
    }
}