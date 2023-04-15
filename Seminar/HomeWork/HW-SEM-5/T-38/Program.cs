// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using System;

class Program
{
    static void Main(string[] args)
    {
        int len = 10; // длина массива
        int top = 100; // верхняя граница случайных чисел
        int but = 1; // нижняя граница случайных чисел

        double[] arr = Gen1DArray(len, top, but); // заполнение массива

        Console.WriteLine("Массив:");
        Print1Darray(arr);

        double max = arr[0];
        double min = arr[0];
        for(int i = 1; i < len; i++)
        {
            if(arr[i] > max)
            {
                max = arr[i];
            }
            if(arr[i] < min)
            {
                min = arr[i];
            }
        }

        double diff = max - min;

        Console.WriteLine($"Разница между максимальным и минимальным элементами: {diff}");
    }

    //Метод печати одномерного массива
    static void Print1Darray(double[] arr)
    {
        Console.Write("[");
        for(int i = 0; i<arr.Length-1; i++)
        {
            Console.Write(arr[i]+", ");
        }
        Console.WriteLine(arr[arr.Length-1] + "]");
    }

    //Заполнение массива
    static double[] Gen1DArray(int len, int top, int but)
    {
        double[] res=new double[len];
        Random rand = new Random();
        for(int i=0; i<len; i++)
        {
            res[i]= rand.NextDouble() * (top - but) + but;
        }
        return res;
    }
}
