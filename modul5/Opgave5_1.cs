using System;
    public class Opgave5_1
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
        // udskriver fordeling
        int[] allGrades = { -3, 0, 2, 4, 7, 10, 12 };

        foreach (var g in allGrades)
        {
            int count = CountGrades(g, grades);
            Console.WriteLine($"Antal {g}: {count}");
        }
    }

    private int CountGrades(int aGrade, List<int> grades)
    {
        int count = 0;
        foreach (int g in grades)
        {
            if (g == aGrade)
                count++;
        }
        return count;
        //return grades.Count(g => g == aGrade);
    }

}
