using System;
public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int[] tempArr = input;

        while (tempArr.Length > 0)
        {
            int index = tempArr.Length / 2;
            int temp = tempArr[index];

            if (tempArr.Length == 1 && temp != value)
                return -1;

            if (temp == value)
                return Array.IndexOf(input, temp);

            if (temp > value)
                tempArr = new ArraySegment<int>(tempArr, 0, index).ToArray();

            if (temp < value)
                tempArr = new ArraySegment<int>(tempArr, index, tempArr.Length - index).ToArray();
        }

        return -1;
    }
}


