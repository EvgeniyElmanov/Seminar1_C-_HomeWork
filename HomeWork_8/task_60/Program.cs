// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] RandomArray()
{
  int[,,] arr = new int[2, 2, 2];
  List<int> list = new List<int>();
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        if (i == 0 && j == 0 && k == 0)
        {
          arr[i, j, k] = new Random().Next(10, 100);
          list.Add(arr[i, j, k]);
        }
        else
        {
          arr[i, j, k] = new Random().Next(10, 100);
          while (list.Contains(arr[i, j, k]))
          {
            arr[i, j, k] = new Random().Next(10, 100);
          }
          list.Add(arr[i, j, k]);
        }
      }
    }
  }
  return arr;
}

void PrintArray2D(int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        Console.Write($"{arr[j, k, i]}({j},{k},{i}) ");
      }
      Console.WriteLine();
    }
  }
}
int[,,] array = RandomArray();
PrintArray2D(array);