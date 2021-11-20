using System;
using System.Collections.Generic;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if (input == "")
            return "";

        char[] tempInput = input.ToCharArray();
        List<char> reversedString = new List<char>();

        for (int i = tempInput.Length - 1; i >= 0; i--)
        {
            reversedString.Add(tempInput[i]);
        }

        return new string(reversedString.ToArray());

    }
}