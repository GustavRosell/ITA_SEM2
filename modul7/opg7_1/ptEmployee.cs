public class ptEmployee : employee
{
    public decimal hourlyWage { get; set; }
    public int hoursWorked { get; set; }

    public decimal calculateSalary()
    {
        decimal totalSalary = hourlyWage * hoursWorked;

        if (hasLunch && !isFullTime)
        {
            totalSalary -= 0.3m * 350; // 30% rabat på frokostordning
        }

        totalSalary -= hasGiftBox ? 30 : 0; // Gavekasse

        totalSalary -= deduction; // Fradrag
        totalSalary -= (totalSalary * drawPercentage) / 100; // Trækprocent

        return totalSalary;
    }

    // Metode til udskrivning af lønseddel for deltidsansatte
    public override void PrintPaySlip()
    {
        base.PrintPaySlip();
        Console.WriteLine($"Timeløn: {hourlyWage}");
        Console.WriteLine($"Antal timer arbejdet: {hoursWorked}");
        Console.WriteLine($"Total løn: {calculateSalary()}");
    }
}