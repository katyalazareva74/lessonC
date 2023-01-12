//  Есть массив на входе. Нужно найти максимальную сумму  m элементов, идущих подряд.
// Пусть будет 10 элементов, найти сумму трех элементов, идущих подряд.
using System.Diagnostics;

int size = 1000000;
int m = 30000;
int[] array = Enumerable.Range(1, size)
                .Select(item => Random.Shared.Next(10))
                .ToArray();
//Console.WriteLine($"[{string.Join(",", array)}]");
Stopwatch sw = new();
sw.Start();
int max = 0;
// Вариант первый
//for (int i = 0; i < array.Length - m + 1; i++)
//{
//  int t = 0;
//for (int j = i; j < m + i; j++)
//  t = t + array[j];
//if (t > max) max = t;
//}
//Вариант второй
for (int j = 0; j < m; j++)
    max = max + array[j];
int t = max;
//Console.Write($"t={t}, ");
for (int i = 1; i < array.Length - m+1; i++)
{
    t = t - array[i - 1] + array[i + m-1];
   // Console.Write($"t={t}, ");
    if (t > max) max = t;
}
sw.Stop();
Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
Console.WriteLine(max);