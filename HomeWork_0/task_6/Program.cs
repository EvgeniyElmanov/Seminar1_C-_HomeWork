
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine());
int Div = Number % 2;

if (Div == 0)
{
  Console.WriteLine("Yes");
}
else
{
  Console.WriteLine("No");
}