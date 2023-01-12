// Заполнить массив и подсчитать сумму его элементов
//int n = 5;
//int[] array = new int[n];
//for (int i = 0; i < n; i++)
//array[i] = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("[" + string.Join(",", array) + "]");
//int summa = 0;
//for (int i = 0; i < n; i++)
//  summa += array[i];
//Console.WriteLine(summa);
// Заполнить таблицу умножения
int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < n; i++)
//{
//  for (int j = 0; j < n; j++)
//{
//  Console.Write((i+1) * (j+1));
//Console.Write("\t");
//}
//Console.WriteLine();
//}
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int k = 0; k < i; k++)
    {
        Console.Write($"     {matrix[i, k]}");
    }
    for (int j = i; j < n; j++)
    {

        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
        Console.Write($"     {matrix[i, j]}");
    }
    Console.WriteLine();
}
