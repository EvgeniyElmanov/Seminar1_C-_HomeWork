// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralMatrix(int m, int n)
{
  int[,] array = new int[m, n];
  int count = 0;
  for (int i = 0; i < m - 1 - i; i++)
  {
    for (int j = i; j < n - 1 - i; j++)
    {
      array[i, j] = ++count;
    }
    for (int j = i; j < m - 1 - i; j++)
    {
      array[j, n - 1 - i] = ++count;
    }
    for (int j = m - 1 - i; j > i; j--)
    {
      array[n - 1 - i, j] = ++count;
    }
    for (int j = m - 1 - i; j > i; j--)
    {
      array[j, i] = ++count;
    }
  }
  if (m % 2 != 0 && n % 2 != 0)
    array[m / 2, n / 2] = ++count;
  return array;
}

void RandomArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write("{0, 3:00}", arr[i, j]);
    }
    Console.WriteLine();
  }
}
int[,] matrix = SpiralMatrix(4, 4);
RandomArray(matrix);