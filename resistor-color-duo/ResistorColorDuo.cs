using System;
using System.Collections.Generic;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        Dictionary<string, char> BandColors = new();
        BandColors.Add("black", '0');
        BandColors.Add("brown", '1');
        BandColors.Add("red", '2');
        BandColors.Add("orange", '3');
        BandColors.Add("yellow", '4');
        BandColors.Add("green", '5');
        BandColors.Add("blue", '6');
        BandColors.Add("violet", '7');
        BandColors.Add("grey", '8');
        BandColors.Add("white", '9');

        char[] charValues = new char[2];


        for (int i = 0; i < 2; i++)
        {
            charValues[i] = BandColors[colors[i]];
        };

        string strValue = new string(charValues);

        Console.WriteLine(strValue);

        return Int32.Parse(strValue);
    }
}
