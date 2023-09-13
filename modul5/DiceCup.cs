using System;
using System.Collections.Generic;

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

public class DiceCup
{
    private List<Dice> dices;
    private List<List<int>> history;

    public DiceCup(int numberOfDices = 2)
    {
        dices = new List<Dice>();
        history = new List<List<int>>();

        for (int i = 0; i < numberOfDices; i++)
        {
            dices.Add(new Dice());
        }
    }

    public List<List<int>> History => history;

    public void Roll()
    {
        List<int> rolls = new List<int>();
        foreach (var dice in dices)
        {
            dice.Roll();
            rolls.Add(dice.Eyes);
        }
        history.Add(rolls);
    }

    public void ResetHistory()
    {
        history.Clear();
    }
}
