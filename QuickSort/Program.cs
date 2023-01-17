int[] arr = { 0, -5, 2, 8, 5, 9, -1, 7 };
int[] res = QuickSort(arr, 0, arr.Length-1);
Console.WriteLine($"Отсортированный массив {string.Join(",", res)}");

int[] QuickSort(int[] InputArray, int minIndex, int maxIndex)
{
    if(minIndex >= maxIndex) return InputArray;
    int pivot = GetPivotIndex(InputArray, minIndex, maxIndex);
    QuickSort(InputArray, minIndex, pivot - 1);
    QuickSort(InputArray, pivot + 1, maxIndex);
    return InputArray;
}
int GetPivotIndex(int[] InputArray, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex-1;
    for (int i = minIndex; i < maxIndex; i++)
    {
        if (InputArray[i] < InputArray[maxIndex])
        {
            pivotIndex++;
            Swap(ref InputArray[pivotIndex], ref InputArray[i]);
           // Swap1(int[] InputArray, i, pivotIndex);
        }
    }
        pivotIndex++;
        Swap(ref InputArray[pivotIndex], ref InputArray[maxIndex]);
        return pivotIndex;
    }
void Swap(ref int leftValue, ref int rightValue)
{
    int temp = leftValue;
    leftValue = rightValue;
    rightValue = temp;
}
void Swap1(int[] InputArray, int leftValue, int rightValue)
{
    int temp = InputArray[leftValue];
    InputArray[leftValue] = InputArray[rightValue];
    InputArray[rightValue] = temp;
}