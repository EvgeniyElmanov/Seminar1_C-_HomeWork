// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void GetSumArray(int[,] arr)
{
  int tempsum = 0;
  int sum = tempsum;
  int index = 0;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      tempsum += arr[i, j];
    }
    if (i == 0)
    {
      sum = tempsum;
      tempsum = 0;
      continue;
    }
    if (tempsum < sum)
    {
      sum = tempsum;
      index = i;
    }
    tempsum = 0;
  }
  Console.WriteLine();
  Console.WriteLine($"the line number with the smallest sum of elements: {index + 1}");
}

void RandomArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(10);
      Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
  }
}
int[,] matrix = new int[4, 4];
RandomArray(matrix);
GetSumArray(matrix);