using System;

public class MafiaDice : Dice
{
    public MafiaDice() : base()
    {
        // MafiaDice arver alt fra Dice-klassen
    }

    public new string Type => "MafiaDice"; // Overskriver metoden for at returnere terningens type

    public new void Roll()
    {
        // Giver en 6'er lidt oftere
        int randomValue = random.Next(1, size);
        if (randomValue == 6)
        {
            eyes = 6;
        }
        if (randomValue == 1)
        {
            eyes = 6;
        }
        else
        {
            eyes = randomValue;
        }
    }
}