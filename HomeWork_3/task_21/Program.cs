// // Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// d=sqrt(x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2)

double GetLength(int x2, int x1, int y2, int y1, int z2, int z1)
{
  double result = (double)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
  return result;
}

int GetNum(string text)
{
  Console.WriteLine(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int x1 = GetNum("Enter point value A : ");
int y1 = GetNum("Enter point value A : ");
int z1 = GetNum("Enter point value A : ");
int x2 = GetNum("Enter point value B : ");
int y2 = GetNum("Enter point value B : ");
int z2 = GetNum("Enter point value B : ");

double length = GetLength(x2, x1, y2, y1, z2, z1);

Console.WriteLine($"Distance between points: {Math.Round(length, 2)}");