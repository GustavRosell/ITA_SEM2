public class Dice
{
    private static Random rng = new Random();
    public int Sides { get; private set; }
    public int CurrentValue { get; private set; }

    public Dice(int sides = 6)
    {
        Sides = sides;
        Roll();
    }

    public void Roll()
    {
        CurrentValue = rng.Next(1, Sides + 1);
    }
}