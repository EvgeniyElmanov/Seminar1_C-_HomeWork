// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter the number day: ");
int dayWeek = int.Parse(Console.ReadLine());

if (dayWeek >= 6 && dayWeek <= 7)
  {
    Console.WriteLine($"{dayWeek} -> Yes:");
  }
else
  {
    Console.WriteLine($"{dayWeek} -> No");
  }


