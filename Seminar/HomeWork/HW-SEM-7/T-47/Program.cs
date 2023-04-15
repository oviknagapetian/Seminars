// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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
