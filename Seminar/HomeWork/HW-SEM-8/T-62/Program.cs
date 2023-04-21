// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



// Метод для вывода двумерного массива
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            double value = arr[i, j];
            int decimals = 0; // количество знаков после запятой
            string format = "{0:f" + decimals + "}"; // формат вывода с заданным количеством знаков после запятой
            Console.Write(string.Format(format, value) + " ");

        }
        Console.WriteLine();
    }
}


// Метод для заполнения двумерного массива в спиральном порядке
int[,] Spiral2DArray(int n)
{
    int[,] arr = new int[n, n];
    int x = 0;
    int y = 0;
    int i = 1;
    int dx = 0;
    int dy = 1;
    while (i <= n * n)
    {
        arr[x, y] = i;
        i++;
        if (x + dx < 0 || x + dx == n || y + dy < 0 || y + dy == n || arr[x + dx, y + dy] != 0)
        {
            int temp = dx;
            dx = dy;
            dy = -temp;
        }
        x += dx;
        y += dy;
    }
    return arr;
}

// Генерация и вывод двумерного массива в спиральном порядке
int n = 4; // размер массива
int[,] arr2 = Spiral2DArray(n); // заполнение массива в спиральном порядке
Print2DArray(arr2);