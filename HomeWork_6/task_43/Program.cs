// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void InrerPoint(double b1, double k1, double b2, double k2)
{
  double x = (b2 - b1) / (k1 - k2);
  double y = k1 * x + b1; 
  Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}

double GetNum(string text)
{
  Console.Write(text);
  double number = double.Parse(Console.ReadLine());
  return number;
}

double b1 = GetNum("Enter point  B1: ");
double k1 = GetNum("Enter point  K1: ");
double b2 = GetNum("Enter point  B2: ");
double k2 = GetNum("Enter point  K2: ");

InrerPoint(b1, k1, b2, k2);