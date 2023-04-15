// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// * Дополнительно диагональ выделить разным цветом.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод для заполнения двумерного массива
int[,] Fill2DArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("Введите элемент [{0}, {1}]: ", i, j);
            arr[i, j] = int.Parse(Console.ReadLine());
        }
    }
    return arr;
}

// Метод для вывода двумерного массива с выделением элементов по диагонали
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j) // если элемент на диагонали
            {
                Console.ForegroundColor = ConsoleColor.Red; // выделение красным цветом
            }
            Console.Write(arr[i, j] + " ");
            Console.ResetColor(); // сброс цвета
        }
        Console.WriteLine();
    }
}

// Метод для вычисления среднего арифметического элементов каждого столбца
void PrintColumnAverages(int[,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);

    for (int j = 0; j < n; j++)
    {
        int sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum += arr[i, j];
        }
        double average = (double)sum / m;
        Console.WriteLine("Среднее арифметическое элементов в столбце {0}: {1}", j + 1, average);
    }
}

// Заполнение и вывод двумерного массива
int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");
int[,] arr2 = Fill2DArray(m, n);
Print2DArray(arr2);

// Вычисление среднего арифметического элементов каждого столбца
PrintColumnAverages(arr2);
