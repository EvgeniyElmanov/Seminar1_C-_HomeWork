
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число:");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB) ;
{
  Console.WriteLine("max: " + numberA);
}
if (numberA < numberB) ;
{
  Console.WriteLine("min: " + numberB);
}