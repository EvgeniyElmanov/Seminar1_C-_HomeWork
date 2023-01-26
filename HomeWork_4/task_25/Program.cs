// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNum(int numberA, int numberB)
{
  int result = 1;
  for (int i = 1; i <= numberB; i++)
  {
    result = result * numberA;
  }
  return result;
}

int DegreeNumber(string text)
{
  Console.WriteLine(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int numberA = DegreeNumber("Enter number A: ");
int numberB = DegreeNumber("Enter number B: ");

int degreeNum = GetNum(numberA, numberB);
Console.WriteLine($"degree of numbers A: {degreeNum}");