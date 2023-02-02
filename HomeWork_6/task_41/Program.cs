// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountNumber(int[] num)
{
  int count = 0;
  for (int i = 0; i < num.Length; i++)
  {
    if (num[i] > 0) count++;
  }
  return count;
}

int[] GetNumber(int size)
{
  int[] arr = new int[size];
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{i + 1}: ");
    arr[i] = int.Parse(Console.ReadLine());
  }
  return arr;
}

int EntNumber(string text)
{
  Console.WriteLine(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int number = EntNumber("Enter number: ");
int[] res = GetNumber(number);
Console.WriteLine(string.Join(",", res) + " -> " + CountNumber(res));