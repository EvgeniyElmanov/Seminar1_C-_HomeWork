// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNat(int m, int n)
{
  if(m == n) return n;
  else return m + SumNat(m + 1, n);
}

int GetNum(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int sizeM = GetNum("Enter of number M: ");
int sizeN = GetNum("Enter of number N: ");

int sum = SumNat(sizeM, sizeN);
Console.WriteLine($"M = {sizeM}; N = {sizeN} -> {sum}");