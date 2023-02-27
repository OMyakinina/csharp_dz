// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void PrintRowMinSumElements(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    int min = 0;
    int imin = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            sum[i] += matrix[i, j];

        if (i == 0) min = sum[i];
        else
        {
            if (min > sum[i])
            {
                min = sum[i];
                imin = i;
            }
        }
    }

    Console.WriteLine(imin + 1 + " - номер строки с наименьшей суммой элементов ");
}
int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");

var myMatrix = GenerateMatrix(rows, cols);

PrintMatrix(myMatrix);
PrintRowMinSumElements(myMatrix);
