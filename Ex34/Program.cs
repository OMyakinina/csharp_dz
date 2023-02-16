// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// функция генирации массива
int[] GetArray(int a, int leftrange, int rightrange) {
    int[] array_rand = new int[a];
    Random rand = new Random ();
    for (int i = 0; i < a; i++) {
        array_rand[i] = rand.Next(leftrange, rightrange + 1);
    }
    return array_rand;
}

// функция подсчета четных элементов
int Counter(int[] arr) {
    int counter = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i]%2 == 0) {
            counter++;
        }
    }
    return counter;    
}

// функция вывода элементов массива и подсчета четных значений
void PrintArray(int[] arr) {
    System.Console.WriteLine("Элементы массива: ["+string.Join(", ", arr)+"]");
    System.Console.WriteLine("Кол-во чётных элементов: " + Counter(arr));
}

// создание массива с помощью функции генерации
int[] myArray = GetArray(5, 100, 999);
// вывод массива с помощью функции вывода
PrintArray(myArray);
