// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    Console.Write(text + "  ");
    return Convert.ToInt32(Console.ReadLine());
}
int AckermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermanFunc(m - 1, 1);
    return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
}

var N1 = ReadInt("Введите неотрицательое число m");
var N2 = ReadInt("Введите неотрицательое число n");
if (N1 >= 0 && N2 >= 0)
    Console.WriteLine($"A(m,n) = {AckermanFunc(N1, N2)}");
else
    Console.WriteLine("Введены некорректные числа");