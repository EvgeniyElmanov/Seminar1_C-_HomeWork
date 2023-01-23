// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int GetNum(string text)
{
  Console.WriteLine(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}
void OutNum(int num)
{
  int index = 1;
  while (index < num)
  {
    Console.Write(Math.Pow(index, 3) + ", ");
    index++;
  }
  Console.Write(Math.Pow(num, 3));
}
int number = GetNum("Enter number: ");
OutNum(number);