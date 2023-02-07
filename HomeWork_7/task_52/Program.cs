// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Getavarage(int[,] matrix)
{
  Console.Write("avarage of columns: ");
  double summa = 0;
  double avarage = 0;
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
      summa += matrix[j, i];
    }
    avarage = summa / matrix.GetLength(0);
    Console.Write(Math.Round(avarage, 1) + "; ");
    summa = 0;
  }
  Console.WriteLine();
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

int sizeRows = GetNum("Enter of number rows: ");
int sizeColumns = GetNum("Enter of number columns: ");

int[,] matrix = new int[sizeRows, sizeColumns];

RandomArray(matrix);
Getavarage(matrix);