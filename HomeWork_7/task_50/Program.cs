// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PosElement(int[,] arr, int sizeM, int sizeN)
{
  int rows = arr.GetLength(0);
  int cols = arr.GetLength(1);
  if (sizeM < rows && sizeN < cols)
  {
    Console.WriteLine($"element positions: [{sizeM}, {sizeN}] their meaning {arr[sizeM, sizeN]}");
  }
  else Console.WriteLine($" [{sizeM},{sizeN}] -> there is no such number in the array");
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

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}
 int[,] matrix = new int[3, 4];
RandomArray(matrix);
int sizeM = GetNum("enter element rows: ");
int sizeN = GetNum("enter element columns: ");
PosElement(matrix, sizeM, sizeN);