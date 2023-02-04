// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N>=100 && N<1000)
{
System.Console.WriteLine("Введено трехзначное число: " + N);
System.Console.WriteLine("Вторая цифра числа: " + (N / 10)% 10);
}
else
{
System.Console.WriteLine("Введено не трехзначное число ");
}