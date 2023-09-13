class Program
{
    static void Main()
    {
        // Opretter et DiceCup objekt med to terninger
        DiceCup cup = new DiceCup();

        // Kaster terningerne og tilføjer resultatet til historikken
        cup.Roll();

        // Udskriver historikken
        foreach (var rolls in cup.History)
        {
            Console.WriteLine(string.Join(", ", rolls));
        }

        // Nulstiller historikken
        cup.ResetHistory();
    }
}