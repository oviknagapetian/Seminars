// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;

class Program
{
    static void Main(string[] args)
    {
        int len = 4; // длина массива
        int top = 999; // верхняя граница случайных чисел
        int but = 100; // нижняя граница случайных чисел

        int[] arr = Gen1DArray(len, top, but); // заполнение массива
        Print1Darray(arr); // вывод массива на экран

        int even = evenCount(arr); // количество чётных чисел в массиве
        Console.WriteLine($"Количество чётных чисел: {even}"); // вывод результата на экран
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

// Метод. Вычисляем количество четных элементов в заданном массиве целых чисел.
    static int evenCount(int[] arr)
    {
        int res=0;
        for(int i=0; i<arr.Length; i++) // исправление: использование свойства Length массива
        {
            if(arr[i]%2==0)
            {
                res++;
            }
        }
        return res;
    }
}
