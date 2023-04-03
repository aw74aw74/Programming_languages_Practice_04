// Задача 27: Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int NumSum(int num)
{
  int res = 0;
  while (num > 0)
  {
    res += num % 10;
    num = num / 10;
  }
  return res;
}

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр в чиле {a} равна {NumSum(a)}.");