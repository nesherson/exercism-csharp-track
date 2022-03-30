using System;
using System.Linq;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (identifier == string.Empty)
            return string.Empty;

        if (identifier.Contains(" "))
            return identifier.Replace(" ", "_");

        if (identifier.Contains("\0"))
            return identifier.Replace("\0", "CTRL");

        if (identifier.Contains("-"))
        {
            int index = identifier.IndexOf("-");
            if (char.IsLower(identifier[index + 1]))
            {
                var tempStr = identifier.ToCharArray();
                tempStr[index + 1] = char.ToUpper(tempStr[index + 1]);

                return new String(tempStr).Replace("-", "");
            }
        }

        if (identifier.Any(x => !char.IsLetter(x)))
            return string.Empty;

        return identifier;
    }
}
