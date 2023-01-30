// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetSumNum(int[] arr)
{
  int sumRes = 0;
  int size = arr.Length;
  for (int index = 1; index < size; index += 2)
  {
    sumRes += arr[index];
  }
  return sumRes;
}

int[] GetArray(int size)
{
  int[] emptyArray = new int[size];
  for (int index = 0; index < size; index++)
  {
    emptyArray[index] = new Random().Next(0, 100);
  }
  return emptyArray;
}

int[] array = GetArray(10);

Console.Write("[" + String.Join(", ", array));
int res = GetSumNum(array);
Console.WriteLine("] -> " + res);