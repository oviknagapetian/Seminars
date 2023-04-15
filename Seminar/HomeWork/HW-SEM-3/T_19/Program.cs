// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

using System;

class Program 
{ 
    // функция для чтения данных с консоли
    static int ReadData(string message) 
    { 
        Console.WriteLine(message); 
        int res;
        while(!int.TryParse(Console.ReadLine(), out res))
        {
            Console.WriteLine("Ошибка ввода! Введен недопустимый параметр.");
        }
        return res;
    }

// функция для проверки, является ли число палиндромом
    static bool PalTest(int num)
    {
        bool res = false;
        int D1 = num / 10000;
        int D5 = num % 10;
        int D2 = (num / 1000) % 10;
        int D4 = (num / 10) % 10;
        if (D1 == D5 && D2 == D4)
        {
            res = true;
        }
        return res;
    }

    static void Main(string[] args)
    {
        int num = ReadData ("Введите проверяемое число:");
        bool isPalindrome = PalTest(num);
        Console.WriteLine("Число {0} является палиндромом? {1}", num, isPalindrome);
    }

}