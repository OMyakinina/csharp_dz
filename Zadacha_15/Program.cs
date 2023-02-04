// Напишите программу, которая принимает на вход цифру,
// обозначающую день 
// недели, и проверяет, является ли этот день выходным
// 6 -> да
// 7 -> да
// 1 -> нет
System.Console.WriteLine("Введите цифру дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Эта цифра : " + day);

if(day == 6 || day == 7)
{
System.Console.WriteLine("Выходной");
}
else if(day>=1 && day <=5)
{
 System.Console.WriteLine("Не выходной");
}
else
{
System.Console.WriteLine("Такого дня недели не существует");
}