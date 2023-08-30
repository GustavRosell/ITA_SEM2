using System;

public class opg_06
{
    public void Run()
    {
        Console.WriteLine("Beregning af kondital");
        Console.WriteLine("---------------------");

        Console.Write("Indtast løbedistancen i meter: ");
        double løbedistance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Er du en mand (ja/nej)? ");
        bool erMand = Console.ReadLine().ToLower() == "ja";

        Console.Write("Indtast din alder: ");
        int alder = Convert.ToInt32(Console.ReadLine());

        double kondital = BeregnKondiTal(løbedistance, erMand);
        string konditalNiveau = VurderKondiTalNiveau(kondital, alder);

        Console.WriteLine($"Dit beregnede kondital er: {kondital}");
        Console.WriteLine($"Dit konditalniveau er: {konditalNiveau}");
    }

    static double BeregnKondiTal(double dist, bool isMale)
    {
        double kondi = 18.38 + (0.03301 * dist) - (5.92 * (isMale ? 0 : 1));
        return kondi;
    }

    static string VurderKondiTalNiveau(double kondital, int alder)
    {
        // Implementer vurdering af konditalniveau baseret på alder og kondital-værdi
        
        if (alder >= 0 && alder <= 100)
        {
            if (kondital < 28)
            {
                return "Lav";
            }
            else if (kondital < 50)
            {
                return "Middel";
            }
            else
            {
                return "Høj";
            }
        }
        else
        {
            return "Ugyldig alder";
        }
    }
}
