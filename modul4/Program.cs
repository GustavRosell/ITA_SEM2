class Program
{
    static void Main(string[] args)
    {

        // Opgave 4.1
        Dice d = new Dice(); // Opretter almindelig terning
        Console.WriteLine("\nhOpgave 4.1:\nNormal dice rolls:\n");

        for (int i = 0; i < 10; i++)
        {
            d.Roll();
            int eyes = d.Eyes;
            Console.WriteLine($"{eyes}");
        }

        // Opgave 4.2
        MafiaDice md = new MafiaDice(); // Opretter MafiaDice

        Console.WriteLine("Opgave 4.2:\nMafia dice rolls:\n");

        for (int i = 0; i < 10; i++)
        {
            md.Roll();
            int eyes = md.Eyes;
            Console.WriteLine($"{eyes}");
        }

        // Opgave 4.3
        Console.WriteLine("\nOpgave 4.3:\nLotto dice rolls:\n");

        LottoDice lottoDice = new LottoDice(35);

        for (int i = 0; i < 35; i++)
        {
            int drawnNumber = lottoDice.DrawNumber();
            Console.WriteLine("Trukket nummer: " + drawnNumber);
        }

        try
        {
            int invalidNumber = lottoDice.DrawNumber();
            Console.WriteLine("Dette burde ikke blive udskrevet.");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Exception fanget: " + ex.Message);
        }
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
