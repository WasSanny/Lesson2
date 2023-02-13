// Поиск позиции элемента массива с использованием метода!!!

void FillArray(int[] collection)                  // Метод void, который создает массив
{
  int length = collection.Length;                 // получаем длинну массива
  int index = 0;

  while(index < length)
  {
    collection[index] = new Random().Next(1, 10); // к аргументу Collection на позицию индекс положить новое целое случайное число из диапозона 1-10
    index++;
  }
}

void PrintArray(int[] col)                        // Метод void, который печатает (выводит массив)
{
  int count = col.Length;
  int position = 0;

  while(position < count)
  {
    Console.WriteLine(col[position]);              // Выводим на экран значение текущего элемента
    position++;
  }
}

int IndexOf(int[] collection, int find)
{
  int count = collection.Length;
  int index = 0;
  int position = -1; // если элемента который мы ищем нет в массиве, то индех по умолчанию(договоренности) равен -1

  while (index < count)
  {
    if (collection[index] == find)
    {
      position = index;
      break;
    }
    index++;
  }
  return position;
}

int[] array = new int[10];                        // new int[10] - создаем массив из 10 элементов (по умолчанию он наполнен нолями)

FillArray(array);                                 // Вызываем метод
PrintArray(array);                                // Вызываем метод
Console.WriteLine();

int pos = IndexOf(array, 6);
Console.WriteLine(pos);