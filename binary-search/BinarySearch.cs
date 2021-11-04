using System;
public static class BinarySearch
{
    public static int[] SortAscending(int[] arr)
    {
        int[] newArr = arr;

        for (int i = 0; i < newArr.Length; i++)
        {
            for (int j = 0; j < newArr.Length; j++)
            {
                int temp = 0;
                if (newArr[j] > newArr[i])
                {
                    temp = newArr[i];
                    newArr[i] = newArr[j];
                    newArr[j] = temp;
                }
            }
        }
        return newArr;
    }
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


