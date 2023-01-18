// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number <= 99) 
{
  Console.WriteLine($"{number}: третьей цифры нет");
}
else 
{
  while(number > 999)
  number = number / 10;
int numberA = number % 10;
Console.WriteLine($"{number}: {numberA}");
}