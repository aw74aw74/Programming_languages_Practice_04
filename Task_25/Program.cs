// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NumPow(int num1, int num2)
{
  int res = num1;
  for (int i = 2; i <= num2; i++)
  {
    res *= num1;
  }
  return res;
}

Console.Clear();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {a} в степени {b} равно {NumPow(a, b)}.");