public static class SquareRoot
{
    public static int Root(int number)
    {
        var left = 0;
        var right = number + 1;

        while (left != right - 1)
        {
            var midpoint = (left + right) / 2;

            if (midpoint * midpoint <= number)
            {
                left = midpoint;
            }
            else
            {
                right = midpoint;
            }
        }

        return left;
    }
}
