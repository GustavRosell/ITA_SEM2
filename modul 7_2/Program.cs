class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Opgave 5.1:\n");
        // new Opg5_1().Run();
        Console.WriteLine(" ! KOMMENTERET UD !\n");

        Console.WriteLine("\nOpgave 5.2:\n");

        Console.WriteLine("\nOpgave 5.2 V2 eller V3 jeg ved det ikke længere:\n");
        TestDiceCupV2();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static void TestDiceCupV2()
    {
        DiceCupV2 cup = new DiceCupV2(); // Opretter et bæger med standardkonstruktøren

        // Rul alle terninger med kastenummer 1
        cup.RollAllDice(1);

        // Få øjnene fra alle terninger
        List<int> eyesOfAllDice = cup.GetEyesOfAllDice();

        /**
        for (int i = 0; i < eyesOfAllDice.Count; i++)
        {
            Console.WriteLine($"Øjne fra terning {i + 1}: {eyesOfAllDice[i]}");
        }
        */

        // Rul igen med kastenummer 2
        cup.RollAllDice(2);
        eyesOfAllDice = cup.GetEyesOfAllDice();

        /**
        for (int i = 0; i < eyesOfAllDice.Count; i++)
        {
            Console.WriteLine($"Øjne fra terning {i + 1}: {eyesOfAllDice[i]}");
        }
        */

        // Vis historikken sorteret efter flest øjne
        List<(int, int, int)> sortedHistory = cup.History.OrderByDescending(x => Math.Max(x.Item2, x.Item3)).ToList();

        Console.WriteLine("\nHistorik (Sorteret efter flest øjne):");
        foreach (var roll in sortedHistory)
        {
            Console.WriteLine($"Kastenummer: {roll.Item1}, Terning 1: {roll.Item2}, Terning 2: {roll.Item3}");
        }

        // Nulstil historikken
        cup.ResetHistory();

        Console.WriteLine("\nHistorik nulstillet.");
    }
}
