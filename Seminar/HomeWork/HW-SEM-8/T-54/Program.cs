// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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


// Метод для упорядочивания элементов каждой строки двумерного массива по убыванию
void SortRowsDescending(double[,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        for (int j = 1; j < n; j++)
        {
            double key = arr[i, j];
            int k = j - 1;
            while (k >= 0 && arr[i, k] < key)
            {
                arr[i, k + 1] = arr[i, k];
                k--;
            }
            arr[i, k + 1] = key;
        }
    }
}

// Генерация и вывод двумерного массива
int m = ReadData("Введите количество строк: "); // количество строк
int n = ReadData("Введите количество столбцов: "); ; // количество столбцов
double top = ReadData("Введите верхнюю границу случайных чисел: "); // верхняя граница случайных чисел
double but = ReadData("Введите нижнюю границу случайных чисел: "); ; // нижняя граница случайных чисел

double[,] arr2 = Gen2DArray(m, n, top, but); // заполнение массива
Console.WriteLine("Исходный массив:");
Print2DArray(arr2);

SortRowsDescending(arr2); // упорядочивание элементов каждой строки по убыванию
Console.WriteLine("Отсортированный массив:");
Print2DArray(arr2);
