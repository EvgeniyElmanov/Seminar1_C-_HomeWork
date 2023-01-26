// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int number)
{
  int sum = 0;
  while (number != 0)
  {
    sum = sum + (number % 10);
    number = number / 10;
  }
  return sum;
}

int Number(string text)
{
  Console.WriteLine(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int number = Number("Введите число: ");

int result = GetSum(number);
Console.WriteLine($"{number} -> {result}");