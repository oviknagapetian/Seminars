
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
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


// Метод для генерации двумерного массива Фибоначи
double[,] Gen2DArray(int m, int n)
{
    double[,] res = new double[m, n];
    int row = 0, col = 0;
    int fib1 = 0, fib2 = 1, fib3 = 1;
    while (row < m)
    {
        res[row, col] = fib1;
        fib1 = fib2;
        fib2 = fib3;
        fib3 = fib1 + fib2;
        col++;
        if (col == n)
        {
            col = 0;
            row++;
        }
    }
    return res;
}


// Метод для вывода двумерного массива с выделением найденного элемента
void Print2DArray(double[,] arr, int highlightRow, int highlightCol)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            double value = arr[i, j];
            int decimals = 0; // количество знаков после запятой
            string format = "{0:f" + decimals + "}"; // формат вывода с заданным количеством знаков после запятой

            // Если текущая позиция совпадает с заданными, выделяем цветом
            if (i == highlightRow && j == highlightCol)
            {
                Console.Write("\u001b[31m"); // код цвета красный
                Console.Write(string.Format(format, value) + " ");
                Console.Write("\u001b[0m"); // код сброса цвета
            }
            else
            {
                Console.Write(string.Format(format, value) + " ");
            }
        }
        Console.WriteLine();
    }
}


// Генерация и вывод двумерного массива
int m = ReadData("Введите количество строк: "); // количество строк
int n = ReadData("Введите количество столбцов: "); ; // количество столбцов

double[,] arr2 = Gen2DArray(m, n); // заполнение массива

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
    Print2DArray(arr2, i, j);
}
