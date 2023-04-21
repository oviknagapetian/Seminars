// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


//Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод для генерации трехмерного массива
int[,,] Gen3DArray(int m, int n, int p)
{
    int[,,] res = new int[m, n, p];
    List<int> numbers = Enumerable.Range(10, 90).ToList(); // список из двузначных чисел
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                int index = rnd.Next(numbers.Count); // выбираем случайный индекс из списка
                res[i, j, k] = numbers[index]; // записываем число из списка в массив
                numbers.RemoveAt(index); // удаляем использованное число из списка
            }
        }
    }
    return res;
}

// Метод для вывода трехмерного массива
void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                int value = arr[i, j, k];
                Console.Write(value.ToString().PadLeft(2, '0') + "(" + i + "," + j + "," + k + ") ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

// Генерация и вывод трехмерного массива
int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");
int p = ReadData("Введите количество глубины: ");

int[,,] arr3 = Gen3DArray(m, n, p);
Print3DArray(arr3);
