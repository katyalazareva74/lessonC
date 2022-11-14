// Поиск позиции нужного элемента
int [] array = {31, 2, 3, 64, 5, 6, 73, 8, 91};
// int n = array.Length; // возвращает длину массива
//int find = 64, index = 0;
//while (index < n) {
//	if (array[index] == find) {
//		Console.WriteLine(index);
//		break; // если есть два одинаковых элемента
//	}
//		index++;
//	}
// напишем функцию нахождения позиции нужного элемента
int IndexOf (int [] collection, int find) {
	int count = collection.Length;
	int index = 0, position = -1; // обход ситуации поиска несуществующего элемента
	while (index < count) {
			if (collection[index] == find) {
				position = index;
				break;
			}
		index++;
	}
	return position;
}

int pos = IndexOf(array, 52);
Console.WriteLine(pos);
