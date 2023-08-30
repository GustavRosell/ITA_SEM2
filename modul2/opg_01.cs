using System;

class opg_01
{
    public void Run()
    {
        int amount = 15; // Change this to the desired amount for testing
        
        int stamps3 = Stamps3(amount);
        int stamps5 = Stamps5(amount);

        Console.WriteLine($"Amount: {amount}");
        Console.WriteLine($"3-cent stamps needed: {stamps3}");
        Console.WriteLine($"5-cent stamps needed: {stamps5}");
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
