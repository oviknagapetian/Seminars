// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю

using System;

class Program
{
    static void Main(string[] args)
    {
        int len = 10; // длина массива
        int top = 100; // верхняя граница случайных чисел
        int but = 1; // нижняя граница случайных чисел

        int[] arr = Gen1DArray(len, top, but); // заполнение массива
        Print1Darray(arr);

        int sum = SumElmEvenPos(arr);
        Console.WriteLine($"Сумма элементов на нечётных позициях: {sum}");

         // Находим все пары одинаковых элементов
        FindDuplicatePairs(arr);

        Console.ReadKey();
    }

    //Ввод числа
    static int ReadData(string msg)
    {
        Console.Write(msg);
        int res = int.Parse(Console.ReadLine() ?? "0");
        return res;
    }

    //Метод печати одномерного массива
    static void Print1Darray(int[] arr)
    {
        Console.Write("[");
        for(int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ",");
        }
        Console.WriteLine(arr[arr.Length - 1] + "]");
    }

    //Заполнение массива
    static int[] Gen1DArray(int len, int top, int but)
    {
        int[] res = new int[len];
        for(int i = 0; i < len; i++)
        {
            res[i] = new Random().Next(but, top + 1);
        }
        return res;
    }

    //Подсчет суммы элементов на нечетных позициях
    static int SumElmEvenPos(int[] arr)
    {
        int sum = 0;
        for(int i = 1; i < arr.Length; i += 2)
        {
            sum += arr[i];
        }
        return sum;
    }

    // Поиск пар одинаковых элементов
    // static void FindDuplicatePairs(int[] arr)
    // {
    //     Console.WriteLine("Пары одинаковых элементов:");
    //     for (int i = 0; i < arr.Length - 1; i++)
    //     {
    //         for (int j = i + 1; j < arr.Length; j++)
    //         {
    //             if (arr[i] == arr[j])
    //             {
    //                 Console.WriteLine($"{arr[i]}, {arr[j]}");
    //             }
    //         }
    //     }
    // }
    
    
    // Поиск индексов пар одинаковых элементов
    static void FindDuplicatePairs(int[] arr)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    Console.WriteLine($"Пары: ({i}, {j})");
                }
            }
        }
    }

    
}

