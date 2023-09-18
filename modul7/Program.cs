class Program
{

    /**
     * b) 
     * Implementer en metode til udskrivning af en lønseddel. 
     * Denne metode skal være tilgængelig for alle ansatte. 
     */

    public static decimal CalculateTotalGrossSalary(List<employee> employees)
    {
        decimal totalGrossSalary = 0;

        foreach (employee emp in employees)
        {
            if (emp is ftEmployee ftEmp)
            {
                totalGrossSalary += Convert.ToDecimal(ftEmp.monthlySalary);
            }
            else if (emp is ptEmployee ptEmp)
            {
                totalGrossSalary += ptEmp.calculateSalary();
            }
            else if (emp is Consultant consultant)
            {
                totalGrossSalary += consultant.calculateSalary();
            }
        }

        return totalGrossSalary;
    }

    public static decimal CalculateTotalTax(List<employee> employees)
    {
        decimal totalTax = 0;

        foreach (employee emp in employees)
        {
            if (emp is ftEmployee ftEmp)
            {
                totalTax += Convert.ToDecimal(ftEmp.monthlySalary) * Convert.ToDecimal(ftEmp.drawPercentage) / 100;
            }
            else if (emp is ptEmployee ptEmp)
            {
                totalTax += (ptEmp.calculateSalary() * ptEmp.drawPercentage) / 100;
            }
            else if (emp is Consultant consultant)
            {
                totalTax += (consultant.calculateSalary() * consultant.drawPercentage) / 100;
            }
        }

        return totalTax;
    }

    public static void Main(string[] args)
    {
        List<employee> employees = new List<employee>
        {
            new ftEmployee{
                name = "Gustav Rosell",
                address = "BrammersBorgen",
                email = "hehesiu@siu.com",
                deduction = 5000,
                drawPercentage = 32,
                monthlySalary = 23000,
                hasLunch  = true,
                hasGiftBox = false,
                isFullTime = true
            },
             new ptEmployee{
                name = "Pablo Escobar",
                address = "Makkervej 69",
                email = "cocaine@daddy.com",
                deduction = 6000,
                drawPercentage = 28,
                hourlyWage = 150,
                hoursWorked = 120,
                hasLunch = true,
                hasGiftBox = true,
                isFullTime = true
            },

            new Consultant
            {
                name = "Konsulent Karsten",
                address = "Konsulentvej 1",
                email = "konsulent@kage.dk",
                deduction = 0,
                drawPercentage = 10,
                hasLunch = false,
                hasGiftBox = false,
                isFullTime = false,
                honorarium = 15000,
                monthsWorked = 3
            }
        };

        employees.Sort();


        Console.WriteLine("Vil du udskrive lønsedler for alle (alle), fuldtidsansatte (fuldtid), deltidsansatte (deltid), eller konsulenter (konsulent)?");
        string choice = Console.ReadLine();
        Console.WriteLine("\n---------------------------\n");

        foreach (employee emp in employees)
        {
            if ((choice == "alle") ||
                (choice == "fuldtid" && emp is ftEmployee) ||
                (choice == "deltid" && emp is ptEmployee) ||
                (choice == "konsulent" && emp is Consultant))
            {
                emp.PrintPaySlip();
                Console.WriteLine("\n---------------------------\n");
            }
        }


        decimal totalGrossSalary = CalculateTotalGrossSalary(employees);
        decimal totalTax = CalculateTotalTax(employees);

        Console.WriteLine($"Samlet bruttoløn: {totalGrossSalary}");
        Console.WriteLine($"Samlet skat: {totalTax}");

        Console.WriteLine("\n---------------------------\n");
        Console.WriteLine("\nEnter a key to exit...");
        Console.ReadKey();
    }
}