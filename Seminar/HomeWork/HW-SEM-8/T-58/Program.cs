// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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


// Умножение двух матриц
int m = ReadData("Введите количество строк матрицы A: ");
int n = ReadData("Введите количество столбцов матрицы A и количество строк матрицы B: ");
int p = ReadData("Введите количество столбцов матрицы B: ");

// Создание матриц A и B
double[,] A = Gen2DArray(m, n, 10, 0);
double[,] B = Gen2DArray(n, p, 10, 0);

// Создание матрицы C для хранения произведения A и B
double[,] C = new double[m, p];

// Умножение матриц A и B
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < p; j++)
    {
        double sum = 0;
        for (int k = 0; k < n; k++)
        {
            sum += A[i, k] * B[k, j];
        }
        C[i, j] = sum;
    }
}

// Вывод матрицы C
Console.WriteLine("Матрица A:");
Print2DArray(A);
Console.WriteLine("Матрица B:");
Print2DArray(B);
Console.WriteLine("Результирующая матрица C:");
Print2DArray(C);