using static System.Console;
using static System.String;
public static class Sorting
{
    public static int[] SortCounting(this int[] collection)
    {
        int size = collection.Length;
        int max = collection[0];
        for (int i = 1; i < size; i++)
            if (collection[i] > max) max = collection[i];
        //int max = collection.Max(); //  фишка C#
        int[] counter = new int[max + 1];
        for (int i = 0; i < size; i++)
            counter[collection[i]]++;
        int index = 0;
        for (int i = 0; i < max + 1; i++)
        {
            for (int j = 0; j < counter[i]; j++)
            {
                collection[index] = i;
                index++;
            }
        }
        return collection;
    }
}
