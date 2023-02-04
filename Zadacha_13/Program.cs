// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N<100)
{
System.Console.WriteLine("Третьей цифры нет");
}
else if (N>=100 && N<1000)
{
System.Console.WriteLine("Третья цифра числа: " + N%10);
}
else if (N>=10000 && N<100000)
{
System.Console.WriteLine("Третья цифра числа: " + (N/100)%10);
}