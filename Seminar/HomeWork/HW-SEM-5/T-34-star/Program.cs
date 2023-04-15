// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// * Отсортировать массив методом пузырька и подсчета. Сравнить быстродействие методов. Проверку сортировки производить отдельно. Сначало запустить программу с одним методом сортировки, а затем с другим. Проверять на длине массива не мение 10000 элементов.


using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int len = 10000; // длина массива
        int top = 9999; // верхняя граница случайных чисел
        int but = 1000; // нижняя граница случайных чисел

        int[] arr1 = Gen1DArray(len, top, but); // заполнение массива
        int[] arr2 = new int[len];
        Array.Copy(arr1, arr2, len);

        Console.WriteLine("Сортировка методом пузырька");
        var sw = System.Diagnostics.Stopwatch.StartNew();
        BubbleSort(arr1);
        sw.Stop();
        Console.WriteLine($"Время выполнения: {sw.ElapsedMilliseconds} мс");

        Console.WriteLine("Сортировка методом подсчета");
        sw = System.Diagnostics.Stopwatch.StartNew();
        CountSort(arr2, but, top);
        sw.Stop();
        Console.WriteLine($"Время выполнения: {sw.ElapsedMilliseconds} мс");

        Console.WriteLine("Проверка сортировки");
        Print1Darray(arr1);
        Print1Darray(arr2);
    }

    //Ввод числа
    static int ReadData(string msg)
    {
        Console.Write(msg);
        int res = int.Parse(Console.ReadLine() ?? "0");
        return res;
    }

    //Метод печати одномерного массива
    static void Print1Darray(int []arr)
    {
        Console.Write("[");
        for(int i = 0; i<arr.Length-1; i++)
        {
            Console.Write(arr[i]+",");
        }
        Console.WriteLine(arr[arr.Length-1] + "]");
    }

    //Заполнение массива
    static int[] Gen1DArray(int len, int top, int but)
    {
        int[] res=new int[len];
        for(int i=0; i<len; i++)
        {
            res[i]= new Random().Next(but, top+1);
        }
        return res;
    }

    //Сортировка методом пузырька
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n-i-1; j++)
            {
                if(arr[j] > arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
    }

    // Сортировка методом подсчета
    static void CountSort(int[] arr, int but, int top)
    {
        int[] count = new int[top - but + 1];
        for(int i = 0; i < arr.Length; i++)
        {
            count[arr[i]-but]++;
        }
        int index = 0;
        for(int i = 0; i < count.Length; i++)
        {
            for(int j = 0; j < count[i]; j++)
            {
                arr[index] = i + but;
                index++;
            }
        }
    }

}
