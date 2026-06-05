public static class LineUp
{
    public static string Format(string name, int number)
    {
        return $"{name}, you are the {number}{GetSuffix(number)} customer we serve today. Thank you!";
    }

    private static string GetSuffix(int number)
    {
        var numberAsString = number.ToString();

        if (numberAsString.Length > 1)
        {
            var lastTwoNumbers = numberAsString[^2..];

            if (lastTwoNumbers is "11" or "12" or "13")
            {
                return "th";
            }
        }

        return numberAsString.Last() switch
        {
            '1' => "st",
            '2' => "nd",
            '3' => "rd",
            _ => "th"
        };
    }
}
