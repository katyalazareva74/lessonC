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
    public static int[] PrepareParallelSortCounting(this int[] collection, int numthread)
    {
        int size = collection.Length;
        int max = collection.Max();
        int min = collection.Min(); //  фишка C#
        int offset = -min;
        int[] counter = new int[max + 1 + offset];
        int eachThreadCalc = size / numthread;
        var threadsParall = new List<Thread>(); // список хранения threads
        for (int i = 0; i < numthread; i++)
        {
            int startPos = i * eachThreadCalc;
            int endPos = (i + 1) * eachThreadCalc;
            if (i == numthread - 1)
                endPos = size;
            threadsParall.Add(new Thread(() => CountingSortParallel(collection, counter, offset, startPos, endPos)));
            threadsParall[i].Start();
            foreach (var thread in threadsParall)
                thread.Join();
        }
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
    public static int[] CountingSortParallel(this int[] collection, int[] counter, int offset, int startPos, int endPos)
    {
        object locker = new object();
        for (int i = startPos; i < endPos; i++)
        {
            lock (locker)
            {
                counter[collection[i] + offset]++;
            }
        }
        return counter;
    }
    public static bool EqualityMatrix(this int[] fmatrix, int[] smatrix)
    {
        bool res = true;
        for (int i = 0; i < fmatrix.Length; i++)
        {
            res = res && (fmatrix[i] == smatrix[i]);
        }
        return res;
    }
}
