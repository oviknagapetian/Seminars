﻿// Задача 63
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

//Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//LineGenRec(5)->Console.Write(5 + " ");
//LineGenRec(5-1)->Console.Write(4 + " ");
//LineGenRec(4-1)->Console.Write(3 + " ");
//LineGenRec(3-1)->Console.Write(2 + " ");
//LineGenRec(2-1)->Console.Write(1 + " ");


void LineGenRec(int numN)
{
    Console.Write(numN + " ");
    if(numN<=1)
    {

    }
    else
    {
    LineGenRec(numN-1);
    }
}

int num = ReadData("Введите число N: ");
LineGenRec(num);