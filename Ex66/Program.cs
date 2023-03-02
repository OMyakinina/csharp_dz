// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int m, int n)
{
    if (n - m + 1 == 0) return 0;
    return SumNumbers(m, n - 1) + n;
}

var M = ReadInt("Введите число М ");
var N = ReadInt("Введите число N ");
Console.WriteLine(SumNumbers(M, N) + " - cумма натуральных элементов от M до N");