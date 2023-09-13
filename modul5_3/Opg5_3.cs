using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Opg5_3
{
    public static void FindMostFrequentWords()
    {
        string fileName = "Gjoengehoevdingen";
        string filePath = Path.Combine("Projects", "ITA_SEM2", "modul5_3", "Opg5_3", fileName);

        try
        {
            string[] lines = File.ReadAllLines(filePath);
            string text = string.Join(" ", lines);

            // Del teksten i ord
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Liste til at holde styr på ordene og deres forekomster
            List<WordCount> wordCounts = new List<WordCount>();

            foreach (string word in words)
            {
                // Tjek om ordet allerede er i listen
                WordCount existingWord = wordCounts.FirstOrDefault(w => w.Word == word);
                if (existingWord != null)
                {
                    existingWord.Count++;
                }
                else
                {
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
            Console.WriteLine("Der opstod en fejl: " + e.Message);
        }
    }

    class WordCount
    {
        public string Word { get; set; }
        public int Count { get; set; }
    }
}