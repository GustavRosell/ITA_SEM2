using System;
using System.Collections.Generic;



public class opg_02
{
    public void Run()
    {
        Console.Write("Indtast antallet af karakterer: ");
        int n = int.Parse(Console.ReadLine());
        List<char> characters = new List<char>();
        List<double> weights = new List<double>();

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Indtast karakter {i + 1}: ");
            char character = char.Parse(Console.ReadLine());
            characters.Add(character);

            Console.Write($"Indtast vægt for karakter {character}: ");
            double weight = double.Parse(Console.ReadLine());
            weights.Add(weight);
        }

        double average = WeightedAverage(characters, weights);
        Console.WriteLine($"Gennemsnit (vægtet): {average:F2}");
    }

    static double WeightedAverage(List<char> characters, List<double> weights)
    {
        if (characters.Count != weights.Count)
        {
            throw new ArgumentException("Antallet af karakterer skal være lig med antallet af vægte.");
        }

        double weightedSum = 0;
        double totalWeight = 0;

        for (int i = 0; i < characters.Count; i++)
        {
            weightedSum += characters[i] * weights[i];
            totalWeight += weights[i];
        }

        if (totalWeight == 0)
        {
            throw new ArgumentException("Totalvægten skal være større end 0.");
        }

        return weightedSum / totalWeight;
    }
}