﻿// See https://aka.ms/new-console-template for more information

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

int[] array = new int[10];

FillArray(array);                                 // Вызываем метод
PrintArray(array);                                // Вызываем метод

//int[] array = new int[10]; // new int[10] - создаем массив из 10 элементов (по умолчанию он наполнен нолями)
