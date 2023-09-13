using System;
using System.Collections.Generic;
using System.Linq;

public class Opg5_1
{
    public void Run()
    {
        List<int> grades = new List<int>();

        while (true)
        {
            Console.Write("Indtast karakter (-1 for at afslutte): ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade == -1)
                break;

            grades.Add(grade);
        }

        if (grades.Count == 0)
        {
            Console.WriteLine("Ingen karakterer indtastet.");
            return;
        }

        var avg = grades.Average();
        Console.WriteLine($"Gennemsnit: {avg}");

        List<int> allGrades = new List<int> { -3, 0, 2, 4, 7, 10, 12 };

        foreach (var g in allGrades)
        {
            int count = CountGrades(g, grades);
            Console.WriteLine($"Antal {g}: {count}");
        }
    }

    private int CountGrades(int aGrade, List<int> grades)
    {
        return grades.Count(g => g == aGrade);
    }
}