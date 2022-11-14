// Поиск позиции нужного элемента
int [] array = {31, 2, 3, 64, 5, 6, 73, 8, 91};
int n = array.Length; // возвращает длину массива
int find = 64, index = 0;
while (index < n) {
	if (array[index] == find) {
		Console.WriteLine(index);
		break; // если есть два одинаковых элемента
	}
		index++;
	}

