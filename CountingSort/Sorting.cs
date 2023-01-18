using static System.Console;
using static System.String;
public static class Sorting
{
    public static int[] SortCounting(this int[] collection)
    {
        int size = collection.Length;
        int max = collection.Max();
        int min = collection.Min(); //  фишка C#
        int offset = -min;
        int[] counter = new int[max + 1 + offset];
        for (int i = 0; i < size; i++)
            counter[collection[i] + offset]++;
        int index = 0;
        for (int i = 0; i < (max + 1 + offset); i++)
        {
            for (int j = 0; j < counter[i]; j++)
            {
                collection[index] = i - offset;
                index++;
            }
        }
        return collection;
    }
}
