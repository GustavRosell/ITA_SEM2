using System;

public class Opgave5_1version2
{

	public void Run()
	{
		Console.Write("Indtast karaktere - slut med -1:");
		var grades = new List<int>();
		int i = 1;
		while (true)
		{
			Console.Write($"Intast karakter nr {i}: ");
			int aGrade = Convert.ToInt32(Console.ReadLine());
			if (aGrade == -1)
				break;
			grades.Add(aGrade);
			i++;
		}
		var avg = grades.Average();
		Console.WriteLine($"Gennemsnit: {avg}");
		// Beregner fordeling
		Dictionary<int, int> counter = new Dictionary<int, int>();

		foreach (var g in grades)
		{
			if (!counter.ContainsKey(g))
				counter.Add(g, 0);
			counter[g]++;
		}
		// Udskriver fordeling
		foreach (var key in counter.Keys)
			Console.WriteLine($"Antal {key}: {counter[key]}");
	}
}
