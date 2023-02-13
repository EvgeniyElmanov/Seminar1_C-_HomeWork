// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunAkkerman(int m, int n)
{
  int funcA = 0;
  if (m > 0 || n > 0)
  {
    if (m == 0) return funcA = n + 1;
    if (n == 0 && m > 0) return FunAkkerman(m - 1, 1);
    return FunAkkerman(m - 1, FunAkkerman(m, n - 1));
  }
  return 0;
}

int GetNumber(string text)
{
  Console.Write(text);
  return int.Parse(Console.ReadLine());
}

int numberM = GetNumber("Enter the number M: ");
int numberN = GetNumber("Enter the number N: ");
int number = FunAkkerman(numberM, numberN);
Console.WriteLine($"m = {numberM}; n = {numberN} -> A(m,n) = {number}");