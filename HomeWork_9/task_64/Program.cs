// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NumNat(int n)
{
  if (n == 0) return;
  Console.Write($"{n}, ");
  NumNat(n - 1);
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int sizeN = GetNum("Enter of number N: ");
Console.Write($"N = {sizeN} -> ");
NumNat(sizeN);
Console.WriteLine();