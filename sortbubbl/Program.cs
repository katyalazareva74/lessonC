// Сортировка пузырьком
Console.WriteLine("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Начальный массив: [" + string.Join(",", array) + "]");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < (n - 1); j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine(i + "[" + string.Join(",", array) + "]");
}
