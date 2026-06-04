using System.Collections;

public static class FlattenArray
{
    public static IEnumerable Flatten(IEnumerable input)
    {
        var list = new List<object>();

        foreach (var item in input)
        {
            if (item is null)
                continue;

            if (item is IEnumerable enumerable)
            {
                var flattenArray = Flatten(enumerable);

                foreach (var item2 in flattenArray)
                {
                    list.AddRange(item2);
                }
            }
            else
            {
                list.Add(item);
            }
        }

        return list;
    }
}
