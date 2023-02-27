// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] GetMatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixNew = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            matrixNew[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
                matrixNew[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
    return matrixNew;
}

var matrix1 = GenerateMatrix(ReadInt("Введите количество строк 1-й матрицы "),
    ReadInt("Введите количество столбцов 1-й матрицы "));
Console.WriteLine(" ");
var matrix2 = GenerateMatrix(ReadInt("Введите количество строк 2-й матрицы "),
    ReadInt("Введите количество столбцов 2-й матрицы "));
Console.WriteLine(" ");
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
if (matrix1.GetLength(1) != matrix2.GetLength(0))
    Console.WriteLine("Умножение матриц невозможно");
{
    var newMatrix = GetMatrixMultiplication(matrix1, matrix2);
    Console.WriteLine(" Результат умножения матриц ");
    Console.WriteLine(" ");
    PrintMatrix(newMatrix);

}

