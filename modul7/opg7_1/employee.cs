using System;
using System.Collections.Generic;

/**
 * Opgave 6.1
Forestil dig du skal lave et lønsystem i en virksomhed, hvor der er to typer af ansatte:
Fast- og deltidsansatte.
For alle ansatte haves navn, adresse, email, fradrag, trækprocent,
om de er med i frokostordningen og om de er med i gavekassen.
For fastansatte haves en månedsløn, mens for deltidsansatte haves en timeløn
og et antal timer som grundlag for udregning af løn.
 */

public class employee : IComparable<employee>
{
    public string name { get; set; }
    public string address { get; set; }
    public string email { get; set; }
    public decimal deduction { get; set; }
    public decimal drawPercentage { get; set; }
    public bool hasLunch { get; set; }
    public bool hasGiftBox { get; set; }
    public bool isFullTime { get; set; }

    // Opgave b) Metode til udskrivning af lønseddel
    public virtual void PrintPaySlip()
    {
        Console.WriteLine($"Navn: {name}");
        Console.WriteLine($"Adresse: {address}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Fradrag: {deduction}");
        Console.WriteLine($"Trækprocent: {drawPercentage}%");
        Console.WriteLine($"Frokostordning: {(hasLunch ? "Ja" : "Nej")}");
        Console.WriteLine($"Gavekasse: {(hasGiftBox ? "Ja" : "Nej")}");
    }

    /**
     * Opgave 7.1
    I opgave 6.1 blev der brugt en liste af ansatte.
    Denne skal nu kunne sorteres efter navn.
    Se metoden Sort() på List<T>.
    Modificer klasserne fra opgave 6.1 så de bliver sorteret efter navn når metoden Sort() kaldes.
     */

    public int CompareTo(employee? other)
    {
        if (other == null)
        {
            return 1;
        }

        return string.Compare(this.name, other.name);
    }
}