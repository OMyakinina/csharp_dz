// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите число ");
string? N = Console.ReadLine();
void Palindrom (string N){
  if (N[0]==N[4] || N[1]==N[3]){
    Console.WriteLine("Введенное число - Палиндром ");
  }
  else Console.WriteLine("Введенное число - не Палиндром ");
}

if (N!.Length == 5){
  Palindrom(N);
}
else Console.WriteLine("Введено не пятизначное число ");