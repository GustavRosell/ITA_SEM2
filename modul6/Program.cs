class Program
{

    /**
     * b) 
     * Implementer en metode til udskrivning af en lønseddel. 
     * Denne metode skal være tilgængelig for alle ansatte. 
     */

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
                hasLunch = true,
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

        Console.ReadKey();
        Console.WriteLine("Enter a key to exit...");
    }
}