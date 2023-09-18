public class Consultant : employee
{
    public decimal honorarium { get; set; }
    public int monthsWorked { get; set; }

    public override void PrintPaySlip()
    {
        base.PrintPaySlip();
        Console.WriteLine($"Honorar: {honorarium}");
        Console.WriteLine($"Antal måneder arbejdet: {monthsWorked}");
        Console.WriteLine($"Total løn: {calculateSalary()}");
    }

    public decimal calculateSalary()
    {
        return honorarium / monthsWorked;
    }
}