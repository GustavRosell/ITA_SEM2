public class DiceCup
{
    private List<Dice> dices;

    public DiceCup(int numberOfDice = 2)
    {
        if (numberOfDice <= 0)
        {
            throw new ArgumentException("Antal terninger skal være mindst 1.");
        }

        dices = new List<Dice>();
        for (int i = 0; i < numberOfDice; i++)
        {
            dices.Add(new Dice());
        }
    }

    public void RollAllDice()
    {
        foreach (var dice in dices)
        {
            dice.Roll();
        }
    }

    public List<int> GetEyesOfAllDice()
    {
        return dices.Select(d => d.Eyes).ToList();
    }
}