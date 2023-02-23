// Задача 52
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.

Random array = new Random();
int[,] arr = new int[array.Next(2, 5), array.Next(2, 5)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = array.Next(1, 10);
        Console.Write(arr[i, j] + "\t ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{Math.Round( sum / arr.GetLength(0),2)} \t");
}
System.Console.WriteLine();