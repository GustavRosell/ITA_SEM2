using System;

public class opg_01
{
    public void Run()
    {
        Console.WriteLine("Opgave 3.1 - Beregning af gennemsnit, varians og standardafvigelse af tal");
        Console.Write("Indtast antallet af tal: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Indtast tal {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        double average = Average(numbers);
        double variance = Variance(numbers);
        double deviation = Deviation(numbers);

        Console.WriteLine($"Gennemsnit: {average}");
        Console.WriteLine($"Varians: {variance}");
        Console.WriteLine($"Standardafvigelse: {deviation}");

        Console.WriteLine("\nOpgave 3.2 - Beregning af gennemsnit med vægte for karakterer");
        Console.Write("Indtast antallet af karakterer: ");
        int m = int.Parse(Console.ReadLine());

        char[] characters = new char[m];
        double[] weights = new double[m];

        for (int i = 0; i < m; i++)
        {
            Console.Write($"Indtast karakter {i + 1}: ");
            characters[i] = char.Parse(Console.ReadLine());

            Console.Write($"Indtast vægt for karakter {characters[i]}: ");
            weights[i] = double.Parse(Console.ReadLine());
        }

        double weightedAverage = WeightedAverage(characters, weights);

        Console.WriteLine($"Vægtet gennemsnit: {weightedAverage}");
    }

    static double Average(int[] a)
    {
        double sum = 0;
        foreach (int num in a)
        {
            sum += num;
        }
        return sum / a.Length;
    }

    static double Variance(int[] a)
    {
        double avg = Average(a);
        double sumOfSquares = 0;
        foreach (int num in a)
        {
            sumOfSquares += Math.Pow(num - avg, 2);
        }
        return sumOfSquares / a.Length;
    }

    static double Deviation(int[] a)
    {
        return Math.Sqrt(Variance(a));
    }

    static double WeightedAverage(char[] chars, double[] weights)
    {
        double weightedSum = 0;
        double totalWeight = 0;

        for (int i = 0; i < chars.Length; i++)
        {
            weightedSum += chars[i] * weights[i];
            totalWeight += weights[i];
        }

        return weightedSum / totalWeight;
    }
}