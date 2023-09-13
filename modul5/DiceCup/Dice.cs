using System;

public class Dice
{
    public int size;
    public int eyes;
    public Random random;

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

    public int Eyes => eyes;
}