using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;

        for (int i = 1; i <= max; i++)
            sum += i;

        return Convert.ToInt32(Math.Pow(sum, 2));
    }

    public static int CalculateSumOfSquares(int max)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}