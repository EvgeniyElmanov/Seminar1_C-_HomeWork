// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome(int number)
{
  if (number % 10 != number / 10000) Console.WriteLine("No palindrome");
  else if (number % 10000 / 1000 == number / 1000 % 10) Console.WriteLine("Yes palindrome");
}

int GetNum(string text)
{
  Console.WriteLine(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int num = GetNum("Enter number: ");
Palindrome(num);