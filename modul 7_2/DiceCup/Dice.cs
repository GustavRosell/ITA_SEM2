public class Dice : IComparable<Dice>
{
    public int size;
    public int eyes;
    public Random random;

    public string Type => "Dice"; // Ny metode til at returnere terningens type


    public Dice(int size = 6 + 1)
    {
        this.size = size;
        random = new Random();
        Roll();
    }

    public void Roll()
    {
        eyes = random.Next(1, size);
    }

    public int CompareTo(Dice? other)
    {
        if (other == null)
        {
            return 1;
        }
        return Eyes.CompareTo(other.eyes);
    }

    public int Eyes => eyes;
}