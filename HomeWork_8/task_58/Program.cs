// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetWorkArray(int[,] first, int[,] second)
{
  int[,] matrix = new int[first.GetLength(0), second.GetLength(1)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < second.GetLength(0); k++)
      {
        matrix[i, j] += first[i, k] * second[k, j];
      }
    }
  }
  return matrix;
}

int[,] RandomArray(int rows, int cols)
{
  int[,] arr = new int[rows, cols];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      arr[i, j] = new Random().Next(1, 10);
    }
  }
  return arr;
}

void PrintArray(int[,] array)
{
  int rows = array.GetLength(0);
  int cols = array.GetLength(1);

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      Console.Write("{0,4}", array[i, j]);
    }
    Console.WriteLine();
  }
}

int[,] secondMatrix = RandomArray(2, 2);
int[,] firstMatrix = RandomArray(2, 2);
PrintArray(secondMatrix);
Console.WriteLine();
PrintArray(firstMatrix);
Console.WriteLine("  result matrix: ");
int[,] avarageMatrix = GetWorkArray(secondMatrix, firstMatrix);
PrintArray(avarageMatrix);