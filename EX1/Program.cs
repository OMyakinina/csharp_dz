// Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
System.Console.Write("Введите число a : ");
int number_a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число b : ");
int number_b = Convert.ToInt32(Console.ReadLine());

if (number_a>number_b)
{
    System.Console.WriteLine(" Большее число: " + number_a);
}
else 
System.Console.WriteLine(" Большее число: " + number_b);