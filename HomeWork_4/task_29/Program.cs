// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void ShowArray(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ", ");
  }
  Console.Write(arr[arr.Length - 1] + "]");
}

int[] GetArray()
{
  int[] array = new int[8];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(10);
  }
  return array;
}

ShowArray(GetArray());