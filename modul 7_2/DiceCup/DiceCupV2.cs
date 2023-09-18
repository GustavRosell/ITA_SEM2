public class DiceCupV2
{
    private List<Dice> allDices;
    private List<(int, int, int)> history;

    public List<(int, int, int)> History => history;

    public DiceCupV2(int numberOfDice = 1)
    {
        if (numberOfDice <= 0)
        {
            throw new ArgumentException("Antal terninger skal være mindst 1.");
        }

        allDices = new List<Dice>();
        history = new List<(int, int, int)>();

        for (int i = 0; i < numberOfDice; i++)
        {
            allDices.Add(new Dice());
            allDices.Add(new MafiaDice());
        }
    }

    public void RollAllDice(int rollNumber)
    {
        List<int> eyes = new List<int>();

        foreach (var dice in allDices)
        {
            dice.Roll();
            eyes.Add(dice.Eyes);
        }

        history.Add((rollNumber, eyes[0], eyes[1]));

        Console.WriteLine($"Kast {rollNumber}:");
        for (int i = 0; i < allDices.Count; i++)
        {
            Console.WriteLine($"{allDices[i].Type} - Øjne: {eyes[i]}");
        }

        // Sorter history efter flest øjne
        history = history.OrderByDescending(x => Math.Max(x.Item2, x.Item3)).ToList();
    }


    public List<int> GetEyesOfAllDice()
    {
        List<int> eyes = allDices.Select(d => d.Eyes).ToList();
        eyes.Sort(); // Sorter øjnene i stigende rækkefølge
        return eyes;
    }

    public void ResetHistory()
    {
        history.Clear();
    }
}