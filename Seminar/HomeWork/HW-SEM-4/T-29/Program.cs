// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[8];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = ReadData($"Введите число {i + 1}:");
        }

        PrintArray(arr);
    }

    static int ReadData(string message)
    {
        Console.WriteLine(message);
        int res;
        while (!int.TryParse(Console.ReadLine(), out res))
        {
            Console.WriteLine("Ошибка ввода! Введен недопустимый параметр.");
        }
        return res;
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine("Массив:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
}
