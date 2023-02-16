// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// функция генерации массива
double[] GetArray(int a, int leftrange, int rightrange) 
{
    double[] array_rand = new double[a];
    var rand = new Random ();
    for (int i = 0; i < a; i++) {
        array_rand[i] = Math.Round(rand.Next(leftrange, rightrange + 1) + rand.NextDouble(), 3);
    }
    return array_rand;
}

// функция поиска минимального с максимальным значений и разницы между ними
double[] GetResult(double[] arr) {
    double max = arr[0];
    double min = arr[0];
    double[] result = new double[3];
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] > max) {
            max = arr[i];
        } else if (arr[i] < min) {
            min = arr[i];
        }
    }
    result[0] = min;
    result[1] = Math.Round(max - min, 3);
    result[2] = max;
    return result;
}

// функция печати результата
void PrintResult(double[] arr) {
    double[] result = GetResult(arr);
    System.Console.WriteLine("Массив вещественных чисел: "+string.Join("; ", arr));
    System.Console.WriteLine("Минимальное значение массива: "+result[0]);
    System.Console.WriteLine("Максимальное значение массива: "+result[2]);
    System.Console.WriteLine("Разница между минимальным и максимальным значениями: "+result[1]);
}

// создание массива с помощью функции генерации
double[] myArray = GetArray(5, 1, 2);
// вывод результата с помощью функции печати
PrintResult(myArray);
