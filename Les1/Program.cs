// Вариант 2! Нахождение максимального значения из 9 чисел с помощью созданной функции с тремя аргументами//
//
int Max(int arg1, int arg2, int arg3) // создали функцию Max:
{                                     // Код, который отвечает
  int result = arg1;                  // отвечает за поиск
  if (arg2 > result) result = arg2;   // максимума
  if (arg3 > result) result = arg3;   //    из
  return result;                      //      трех
}                                      //         чисел!

int a1 = 1500;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 333;

// int max1 = Max(a1, b1, c1);      // Находим максимальное значение из первой тройки чисел 
// int max2 = Max(a2, b2, c2);      // Находим максимальное значение из второй тройки чисел 
// int max3 = Max(a3, b3, c3);      // Находим максимальное значение из третьей тройки чисел 
// int max = Max(max1, max2, max3); // Выбираем максимальное число из трех максимальных в тройках

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

// Console.WriteLine(max1); // Выводим максимальный элемент первой тройки чисел
// Console.WriteLine(max2); // Выводим максимальный элемент второй тройки чисел
// Console.WriteLine(max3); // Выводим максимальный элемент третьей тройки чисел
Console.WriteLine(max); // Выводим максимальный элемент 


// Вариант 1! Нахождение максимального значения из 9 чисел обечным методом//
//
// int a1 = 1500;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 333;

// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

// Console.WriteLine(max);

