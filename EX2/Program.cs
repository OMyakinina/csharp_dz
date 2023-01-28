// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.

System.Console.Write("Введите число a : ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число b : ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число c : ");
int c = Convert.ToInt32(Console.ReadLine());

if (a>b && a>c)
{
    System.Console.WriteLine("Максимальное из этих чисел : " + a);
} 
else if (b>a && b>c)
{
    System.Console.WriteLine("Максимальное из этих чисел : " + b);
} 
else if (c>a && c>b)
{
    System.Console.WriteLine("Максимальное из этих чисел : " + c);
} 
else 
{
     System.Console.WriteLine("Максимума нет");
}