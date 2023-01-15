
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int Number = 2;

if (Nnumber > 1)
{
  while (Number <= N)
  {
    Console.Write(Number + ", ");
    Number = Number + 2;
  }
}