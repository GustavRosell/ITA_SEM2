class Program
{
    static void Main(string[] args)
    {
        Dice d = new Dice();

        Console.WriteLine("You've rolled:\n");

        for (int i = 0; i < 10; i++)
        {
            d.Roll();
            int eyes = d.Eyes;
            Console.WriteLine($"{eyes}");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}