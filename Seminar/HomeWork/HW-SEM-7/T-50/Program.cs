// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



//Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод для генерации двумерного массива
double[,] Gen2DArray(int m, int n, double top, double but)
{
    double[,] res = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().NextDouble() * (top - but) + but;
        }
    }
    return res;
}

// Метод для вывода двумерного массива
void Print2DArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            double value = arr[i, j];
            int decimals = 2; // количество знаков после запятой
            string format = "{0:f" + decimals + "}"; // формат вывода с заданным количеством знаков после запятой
            Console.Write(string.Format(format, value) + " ");

        }
        Console.WriteLine();
    }
}

// Генерация и вывод двумерного массива
int m = ReadData("Введите количество строк: "); // количество строк
int n = ReadData("Введите количество столбцов: "); ; // количество столбцов
double top = ReadData("Введите верхнюю границу случайных чисел: "); // верхняя граница случайных чисел
double but = ReadData("Введите нижнюю границу случайных чисел: "); ; // нижняя граница случайных чисел

double[,] arr2 = Gen2DArray(m, n, top, but); // заполнение массива
Print2DArray(arr2);

// Метод для поиска элемента в двумерном массиве
double FindElement(double[,] arr, int i, int j)
{
    // Если позиция находится за пределами массива, возвращаем -1
    if (i < 0 || i >= arr.GetLength(0) || j < 0 || j >= arr.GetLength(1))
    {
        return -1;
    }

    // Возвращаем значение элемента
    return arr[i, j];
}

// Чтение позиции элемента
int i = ReadData("Введите номер строки: ");
int j = ReadData("Введите номер столбца: ");

// Поиск элемента и вывод результата
double element = FindElement(arr2, i, j);
if (element == -1)
{
    Console.WriteLine("Такого элемента нет.");
}
else
{
    Console.WriteLine($"Значение элемента: {element}");
}
