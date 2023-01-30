// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double GetSumMaxAndMin(double[] arr)
{
  double max = arr[0];
  double min = arr[0];
  double dif = 0;
  double size = arr.Length;
  for (int index = 1; index < size; index++)
  {
    if (arr[index] > max) max = arr[index];
    else if (arr[index] < min) min = arr[index];
  }
  dif = max - min;
  return dif;
}

double[] GetArray(int size)
{
  double[] emptyArray = new double[size];
  for (int index = 0; index < size; index++)
  {
    emptyArray[index] = new Random().Next(0, 100);
  }
  return emptyArray;
}

double[] array = GetArray(5);

Console.Write("[" + String.Join(", ", array));
double res = GetSumMaxAndMin(array);
Console.WriteLine("] -> " + res);