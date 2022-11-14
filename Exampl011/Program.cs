// написание функций заполнения массива и его вывода на экран
int [] array = new int[10];
void FillArray (int [] collection) {
	int length = collection.Length;
	int index = 0;
	while (index < length) {
			collection[index] = new Random().Next(1, 10);
			index++;
}}

void PrintArray (int [] col) {
	int count = col.Length;
	int index = 0;
	while (index < count) {
			Console.WriteLine(col[index]);
			index++;
}}
FillArray (array);
PrintArray (array);
