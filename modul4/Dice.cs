using System;

public class Dice
{

    /**
     * Opgave 4.1
    Du skal lave et program der kan bruges til at bestemme hvor tilfældig terningen
    som blev lavet på klassen egentlig er.
    Du skal bruges klassen Dice som blev lavet på klassen.
    Du skal nu skrive et program som opretter en terning (fra klassen Dice) og i programmet skal terningen kastes mange
    (fx 1.000.000) gange.
    Efterfølgende skal hyppigheden eller frekvens udskrives.
    */

    // Fields:
    public int size;
    public int eyes;
    public Random random;

    // Constructor:
    public Dice(int size = 6 + 1)
    {
        this.size = size;
        random = new Random();
        Roll();
    }

    public void Roll()
    {
        eyes = random.Next(1, size);

    }

    public int Eyes => eyes;
}