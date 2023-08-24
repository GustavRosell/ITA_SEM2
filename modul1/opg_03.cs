/* Opgave 3)
 * 
 * Skriv et program som indlæser et tal 
 * og derefter udskriver summen af tallene fra 1 og op til og med tallet. 
 * Så fx på input 5, skal programmet udskrive 1+2+3+4+5 = 15.
 */

public class opg_03
{
    public void Run()
    {   
        Console.WriteLine("Indtast et tal: ");
        double tal = Convert.ToDouble(Console.ReadLine());
        string equation = "";
        double sum = 0;

        for (int i = 1; i <= tal; i++)
        {
            equation += i;
            sum += i;

            if (i < tal)
            {
                equation += "+";
            }
        }
        Console.WriteLine($"{equation} = {sum}");
    }
}
