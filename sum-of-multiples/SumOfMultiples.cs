using System;
using System.Linq;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        if (!multiples.Any())
            return 0;

        List<int> tempMultiples = multiples.ToList();
        int len = tempMultiples.Count;

        int num = 1;
        int index = 0;
        int curr = 0;
        List<int> uniques = new();

        while (index < len)
        {
            int temp = 0;
            do
            {
                curr = tempMultiples[index];

                if (curr == 0)
                {
                    index++;
                    break;
                }

                temp = curr * num;

                if (temp >= max)
                    break;

                if (!uniques.Contains(temp))
                {
                    uniques.Add(temp);
                }

                num++;
            } while (true);

            num = 0;
            index++;
        }
        return uniques.Sum();
    }
}

