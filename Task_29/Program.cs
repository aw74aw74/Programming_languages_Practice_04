// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] col)
{
  Console.WriteLine($"Введите массив из {col.Length} элементов.");
  for (int index = 0; index < col.Length; index++)
  {
    Console.Write($"Число {index + 1} из {col.Length}: ");
    col[index] = int.Parse(Console.ReadLine()!);
  }
}

int[] array = new int[8];
FillArray(array);
Console.WriteLine($"Массив из {array.Length} элементов : [ {String.Join(", ", array)} ]");