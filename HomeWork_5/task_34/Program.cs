// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetEvenNum(int[] arr)
{
  int result = 0;
  int size = arr.Length;
  for (int index = 0; index < size; index++)
  {
    if (arr[index] % 2 == 0)
    {
      result += 1;
    }
  }
  return result;
}

int[] GetArray(int size)
{
  int[] emptyArray = new int[size];
  for (int index = 0; index < size; index++)
  {
    emptyArray[index] = new Random().Next(100, 1000);
  }
  return emptyArray;
}

int[] array = GetArray(10);

Console.Write("[" + String.Join(", ", array));
int res = GetEvenNum(array);
Console.WriteLine("] -> " + res);