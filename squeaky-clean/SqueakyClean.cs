using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (string.IsNullOrEmpty(identifier))
            return "";

        var result = ToCamelCase(identifier);
        result = RemoveLowerCaseGreekLetters(result);
        // It will remove non letters but preserve white spaces and control characters
        // because they are needed in later stages
        result = RemoveNonLetters(result);
        result = ReplaceControlCharacters(result, "CTRL");
        result = ReplaceWhiteSpaceWithUnderscore(result);

        return result;
    }

    private static string ToCamelCase(string identifier)
    {
        var splitStr = identifier
            .Split('-');

        if (splitStr.Length == 1)
            return identifier;

        var stringBuilder = new StringBuilder(splitStr[0]);

        for (var i = 1; i < splitStr.Length; i++)
        {
            var segment = splitStr[i];

            stringBuilder
                .Append(char.ToUpperInvariant(segment[0]))
                .Append(segment, 1, segment.Length - 1);
        }

        return stringBuilder.ToString();
    }

    private static string RemoveLowerCaseGreekLetters(string identifier)
    {
        var stringBuilder = new StringBuilder();

        for (int i = 0; i < identifier.Length; i++)
        {
            if (identifier[i] >= 'α' && identifier[i] <= 'ω')
                continue;

            stringBuilder.Append(identifier[i]);
        }

        return stringBuilder.ToString();
    }

    private static string RemoveNonLetters(string identifier)
    {
        var stringBuilder = new StringBuilder();

        for (int i = 0; i < identifier.Length; i++)
        {
            if (char.IsWhiteSpace(identifier[i]) || char.IsControl(identifier[i]) || char.IsLetter(identifier[i]))
            {
                stringBuilder.Append(identifier[i]);
            }
        }

        return stringBuilder.ToString();
    }

    private static string ReplaceControlCharacters(string identifier, string replacement)
    {
        var stringBuilder = new StringBuilder();

        for (int i = 0; i < identifier.Length; i++)
        {
            if (char.IsControl(identifier[i]))
            {
                stringBuilder.Append(replacement);
            }
            else
            {
                stringBuilder.Append(identifier[i]);
            }
        }

        return stringBuilder.ToString();
    }

    private static string ReplaceWhiteSpaceWithUnderscore(string identifier)
    {
        var stringBuilder = new StringBuilder();

        for (int i = 0; i < identifier.Length; i++)
        {
            if (char.IsWhiteSpace(identifier[i]))
            {
                stringBuilder.Append('_');
            }
            else
            {
                stringBuilder.Append(identifier[i]);
            }
        }

        return stringBuilder.ToString();
    }
}
