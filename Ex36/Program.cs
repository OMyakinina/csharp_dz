// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях

// функция генерации массива
int[] GetArray(int a, int leftrange, int rightrange) {
    int[] array_rand = new int[a];
    Random rand = new Random ();
    for (int i = 0; i < a; i++) {
        array_rand[i] = rand.Next(leftrange, rightrange + 1);
    }
    return array_rand;
}

// Подсчет суммы чисел на нечетных местах
int Sum(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i+=2)
{
    result = result + array[i];
}
    return result;
}

// вывод массива с помощью функции вывода

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
// создание массива с помощью функции генерации
int[] arr = GetArray(5, 0, 20);
PrintArray(arr);

// Вывод результата
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: " + Sum(arr));
