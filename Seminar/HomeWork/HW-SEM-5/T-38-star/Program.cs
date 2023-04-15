// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// * Отсортируйте массив методом вставки, а затем найдите разницу между первым и последним элементом.


using System;

class Program
{
    static void Main(string[] args)
    {
        int len = 10; // длина массива
        int top = 100; // верхняя граница случайных чисел
        int but = 1; // нижняя граница случайных чисел

        double[] arr = Gen1DArray(len, top, but); // заполнение массива

        // Console.WriteLine("Массив до сортировки:");
        // Print1Darray(arr);

        InsertionSort(arr); // сортировка методом вставки

        Console.WriteLine("Массив после сортировки:");
        Print1Darray(arr);

        double diff = arr[arr.Length - 1] - arr[0]; // нахождение разницы между первым и последним элементом

        Console.WriteLine($"Разница между первым и последним элементом: {diff}");


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


// Сортировка массива методом вставки
static void InsertionSort(double[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int j = i;
            while (j > 0 && arr[j - 1] > arr[j])
            {
                double temp = arr[j - 1];
                arr[j - 1] = arr[j];
                arr[j] = temp;
                j--;
            }
        }
    }
}