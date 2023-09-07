using System;

public class LottoDice
{
    private int[] availableNumbers;
    private int currentIndex;
    private Random random;

    public LottoDice(int maxNumber)
    {
        availableNumbers = new int[maxNumber];
        for (int i = 0; i < maxNumber; i++)
        {
            availableNumbers[i] = i + 1;
        }
        currentIndex = maxNumber - 1;
        random = new Random();
    }

    public int DrawNumber()
    {
        if (currentIndex < 0)
        {
            throw new InvalidOperationException("Ingen flere tilgængelige numre.");
        }

        int index = random.Next(currentIndex + 1);
        int drawnNumber = availableNumbers[index];

        // Byt det trukne nummer med det sidste tilgængelige nummer
        availableNumbers[index] = availableNumbers[currentIndex];
        currentIndex--;

        return drawnNumber;
    }
}