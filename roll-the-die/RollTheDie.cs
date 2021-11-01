using System;

public class Player
{
    public int RollDie()
    {
        var r = new Random();
        var dieNumber = r.Next(1, 18);

        return dieNumber;
    }

    public double GenerateSpellStrength()
    {
        var r = new Random();
        var spellStrength = r.NextDouble() * 100;

        return spellStrength;
    }
}
