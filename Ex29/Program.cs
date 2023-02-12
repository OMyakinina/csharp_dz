// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetArray(int a, int leftrange, int rightrange)
{
int[] array_rand = new int[a];
Random rand = new Random ();

for (int i = 0; i < a; i++)
    array_rand[i] = rand.Next(leftrange, rightrange + 1);

return array_rand;
}

void PrintArray(int[] arr)
{
System.Console.WriteLine("["+string.Join(", ", arr)+"]");
}
int[] myArray = GetArray(12, 10, 101);
PrintArray(myArray);