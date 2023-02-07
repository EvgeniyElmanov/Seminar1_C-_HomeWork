// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void RealArray(double[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 10;
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

int sizeM = GetNum("Enter of number rows: ");
int sizeN = GetNum("Enter of number columns: ");

double[,] matrix = new double[sizeM, sizeN];

RandomArray(matrix);