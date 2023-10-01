public class DiceCup
{
    private List<Dice> dices;

    public DiceCup(int numberOfDices = 2)
    {
        dices = new List<Dice>();

        for (int i = 0; i < numberOfDices; i++)
        {
            dices.Add(new Dice());
        }
    }

    public void Shake()
    {
        foreach (var dice in dices)
        {
            dice.Roll();
        }
    }

    public List<int> GetValues()
    {
        return dices.Select(d => d.CurrentValue).ToList();
    }
}