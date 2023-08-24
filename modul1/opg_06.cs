public class opg_06
{
    public void Run()
    {
        // her skrives løsningen på opgave 1
        Console.WriteLine("Beregning af kondital");
        Console.WriteLine("---------------------");

        Console.Write("Indtast løbedistancen i meter: ");
        double løbedistance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Er du en mand (ja/nej)? ");
        bool erMand = Console.ReadLine().ToLower() == "ja";

        double kondital = BeregnKondiTal(løbedistance, erMand);

        Console.WriteLine($"Dit beregnede kondital er: {kondital:F2}");
    }
    // her placeres eventuelle hjælpe funktioner

    static double BeregnKondiTal(double dist, bool isMale)
    {
        double kondi = 18.38 + (0.03301 * dist) - (5.92 * (isMale ? 0 : 1));
        return kondi;
    }
}