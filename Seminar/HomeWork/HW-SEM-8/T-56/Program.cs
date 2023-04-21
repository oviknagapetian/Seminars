// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


// Метод для поиска строки с наименьшей суммой элементов
int FindRowWithMinSum(double[,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    int minRow = 0;
    double minSum = double.MaxValue;

    for (int i = 0; i < m; i++)
    {
        double sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += arr[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }

    return minRow;
}


// Генерация и вывод двумерного массива
int m = ReadData("Введите количество строк: "); // количество строк
int n = ReadData("Введите количество столбцов: "); ; // количество столбцов
double top = ReadData("Введите верхнюю границу случайных чисел: "); // верхняя граница случайных чисел
double but = ReadData("Введите нижнюю границу случайных чисел: "); ; // нижняя граница случайных чисел

double[,] arr2 = Gen2DArray(m, n, top, but); // заполнение массива
Console.WriteLine("Исходный массив:");
Print2DArray(arr2);


// Поиск строки с наименьшей суммой элементов
int minRow = FindRowWithMinSum(arr2);
Console.WriteLine("Строка с наименьшей суммой элементов: {0}", minRow + 1); // вывод номера строки с наименьшей суммой элементов (нумерация с единицы)
