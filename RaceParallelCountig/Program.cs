using static Sorting;
using static Infrastructure;

const int N = 100000;
int[] resSerial = new int[N];
resSerial = Infrastructure.CreateArray(N, min: -5, max: 10);
         //.Show();
int[] resParall = new int[N];
Array.Copy(resSerial, resParall, N);
//Infrastructure.Show(resParall)
                     Sorting.PrepareParallelSortCounting(resParall, 10);
                   //  .Show();
//Infrastructure.Show(resSerial)
                   Sorting.SortCounting(resSerial);
                  //   .Show();

Console.WriteLine(Sorting.EqualityMatrix(resSerial, resParall));
