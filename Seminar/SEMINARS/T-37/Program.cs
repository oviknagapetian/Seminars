﻿// Задача №37
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

   int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res =  int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

int[] Gen1Darray(int len, int minValue, int maxValue)

{

    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
    }
    return arr;
}

void Print1DArray(int[] arr)

{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] ConverArr (int[] arr)
{
    int len =(arr.Length%2==0)? arr.Length/2:arr.Length/2+1;    
    int[] outArr = new int [len];

    for(int i=0;i <len; i++)
    {
        outArr [i] = arr[i] * arr[arr.Length-1-i];
    }

    return outArr;
}

int Length = ReadData("Введите длину массива: ");
int[] arr = Gen1Darray(Length,999,-999);
Print1DArray (arr);
int[] newArr=ConverArr(arr);
Print1DArray(newArr);