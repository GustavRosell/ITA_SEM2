using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Opg5_3
{
    public static void FindMostFrequentWords()
    {
        string filePath = "/Users/rosell/Projects/ITA_SEM2/modul5_3/Gjoengehoevdingen";

        try
        {
            // Læs filen og gem indholdet som en tekst
            string[] lines = File.ReadAllLines(filePath);
            string text = string.Join(" ", lines);

            // Del teksten i ord
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?', '"' }, StringSplitOptions.RemoveEmptyEntries);

            // Lav en liste til at holde styr på ordene og hvor mange gange de forekommer
            List<WordCount> wordCounts = new List<WordCount>();

            // Gennemgå hvert ord i teksten
            foreach (string word in words)
            {
                // Tjek om ordet allerede er i listen
                WordCount existingWord = wordCounts.FirstOrDefault(w => w.Word == word);
                if (existingWord != null)
                {
                    // Hvis ordet allerede er i listen, øg antallet af gange det er blevet set
                    existingWord.Count++;
                }
                else
                {
                    // Hvis ordet ikke er i listen, tilføj det til listen med antallet 1
                    wordCounts.Add(new WordCount { Word = word, Count = 1 });
                }
            }

            // Find de 10 mest hyppige ord
            var topWords = wordCounts.OrderByDescending(w => w.Count).Take(10);

            // Udskriv resultaterne
            Console.WriteLine("\nDe 10 mest hyppige ord:");

            foreach (var wordCount in topWords)
            {
                Console.WriteLine($"{wordCount.Word}: {wordCount.Count} gange");
            }
        }
        catch (Exception e)
        {
            // Hvis der opstår en fejl, udskriv fejlmeddelelsen
            Console.WriteLine("Der opstod en fejl: " + e.Message);
        }
    }

    // Klasse til at gemme hvert ord og hvor mange gange de forekommer
    class WordCount
    {
        public string Word { get; set; }
        public int Count { get; set; }
    }
}
