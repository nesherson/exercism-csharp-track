public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        if (operand2 == 0)
            return "Division by zero is not allowed.";

        var result = operation switch
        {
            "+" => operand1 + operand2,
            "*" => operand1 * operand2,
            "/" => operand1 / operand2,
            null => throw new ArgumentNullException(),
            "" => throw new ArgumentException(),
            _ => throw new ArgumentOutOfRangeException(),
        };
        return $"{operand1} {operation} {operand2} = {result}";
    }
}
