public class ftEmployee : employee
{
    public double monthlySalary { get; set; }

    // Metode til udskrivning af lønseddel for fuldtidsansatte
    public override void PrintPaySlip()
    {
        base.PrintPaySlip();
        Console.WriteLine($"Månedsløn: {monthlySalary}");
    }
}