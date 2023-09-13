using System.Collections.Generic;
using System;

public class DiceCupV2
{
    private List<Dice> dices;
    private List<(int, int, int)> history; // Tilføjet kastenummer

    public List<(int, int, int)> History => history;

    public DiceCupV2(int numberOfDice = 2)
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

        history = new List<(int, int, int)>(); // Tilføjet kastenummer
    }

    public void RollAllDice(int rollNumber) // Tilføjet kastenummer som argument
    {
        List<int> eyes = new List<int>();
        foreach (var dice in dices)
        {
            dice.Roll();
            eyes.Add(dice.Eyes);
        }
        history.Add((rollNumber, eyes[0], eyes[1])); // Gemmer kastenummer og øjne
    }

    public List<int> GetEyesOfAllDice()
    {
        return dices.Select(d => d.Eyes).ToList();
    }

    public void ResetHistory()
    {
        history.Clear();
    }
}