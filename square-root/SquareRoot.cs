public static class SquareRoot
{
    public static int Root(int number)
    {
        var counter = 0;

        while ((counter + 1) * (counter + 1) <= number)
            counter++;

        return counter;
    }
}
