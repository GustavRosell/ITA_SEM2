using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Indtast stien til tekstfilen: ");
        string filePath = Console.ReadLine();

        try
        {
            string[] lines = File.ReadAllLines(filePath);
            string text = string.Join(" ", lines);

            // Del teksten i ord og fjern specialtegn
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // T�l forekomster af hvert ord
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string cleanedWord = CleanWord(word);
                if (wordCounts.ContainsKey(cleanedWord))
                {
                    wordCounts[cleanedWord]++;
                }
                else
                {
                    wordCounts[cleanedWord] = 1;
                }
            }

            // Find de 10 mest hyppige ord
            var topWords = wordCounts.OrderByDescending(pair => pair.Value).Take(10);

            // Udskriv resultaterne
            Console.WriteLine("\nDe 10 mest hyppige ord:");

            foreach (var pair in topWords)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} gange");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Der opstod en fejl: " + e.Message);
        }
    }
}
