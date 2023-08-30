using System;

class opg_01
{
    public void Run()
    {
        Console.WriteLine("Enter the amount: ");
        int amount = Convert.ToInt32(Console.ReadLine());
        
        int stamps3 = Stamps3(amount);
        int stamps5 = Stamps5(amount);

        Console.WriteLine($"\n3-cent stamps needed: {stamps3}");
        Console.WriteLine($"\n5-cent stamps needed: {stamps5}");
    }

    // Calculate the number of 3-cent stamps needed to frank the given amount
    // amount > 7
    // Returns the number of 3-cent stamps
    static int Stamps3(int amount)
    {
        return amount / 3;
    }

    // Calculate the number of 5-cent stamps needed to frank the given amount
    // amount > 7
    // Returns the number of 5-cent stamps
    static int Stamps5(int amount)
    {
        return amount / 5;
    }
}
