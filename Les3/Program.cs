/// Имеется одномерный массив array из n элементов. Требуется найти
//  элемент массива равный "find"
//
int[] array = {11, 21, 311, 41, 19, 51, 61, 17, 81, 19};

int n = array.Length; // определяем количество элементов массива
int find = 19;

int index = 0;

while (index < n)
{
  if (array[index] == find)     // если выполняется условие
  {                             // тогда
    Console.WriteLine(index);   //    прерываем
    break;                      //        заканчиваем (break)
  }
  index++;
}