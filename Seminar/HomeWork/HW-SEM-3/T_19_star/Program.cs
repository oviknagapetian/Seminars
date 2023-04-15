// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов


using System;
using System.Collections.Generic; // добавляем пространство имен для использования словаря

class Program 
{ 
    // Функция для чтения данных с консоли
    static int ReadData(string message) 
    { 
        Console.WriteLine(message); 
        int res;
        while(!int.TryParse(Console.ReadLine(), out res) || res < 1000 || res > 9999)
        {
            Console.WriteLine("Ошибка ввода! Введите четырехзначное число.");
        }
        return res;
    }
    
    // функция для проверки, является ли число палиндромом
    static bool PalTest(int num)
    {
        bool res = false;
        int D1 = num / 1000; // первая цифра
        int D2 = (num / 100) % 10; // вторая цифра
        int D3 = (num / 10) % 10; // третья цифра
        int D4 = num % 10; // четвертая цифра

        // создаем словарь четырехзначных палиндромов
        Dictionary<int, bool> palindromes = new Dictionary<int, bool>();
        palindromes.Add(1001, true);
        palindromes.Add(1111, true);
        palindromes.Add(1221, true);
        palindromes.Add(1331, true);
        palindromes.Add(1441, true);
        palindromes.Add(1551, true);
        palindromes.Add(1661, true);
        palindromes.Add(1771, true);
        palindromes.Add(1881, true);
        palindromes.Add(1991, true);

        palindromes.Add(2002, true);
        palindromes.Add(2112, true);
        palindromes.Add(2222, true);
        palindromes.Add(2332, true);
        palindromes.Add(2442, true);
        palindromes.Add(2552, true);
        palindromes.Add(2662, true);
        palindromes.Add(2772, true);
        palindromes.Add(2882, true);
        palindromes.Add(2992, true);
        
        palindromes.Add(3003, true);
        palindromes.Add(3113, true);
        palindromes.Add(3223, true);
        palindromes.Add(3333, true);
        palindromes.Add(3443, true);
        palindromes.Add(3553, true);
        palindromes.Add(3663, true);
        palindromes.Add(3773, true);
        palindromes.Add(3883, true);
        palindromes.Add(3993, true);

        palindromes.Add(4004, true);
        palindromes.Add(4114, true);
        palindromes.Add(4224, true);
        palindromes.Add(4334, true);
        palindromes.Add(4444, true);
        palindromes.Add(4554, true);
        palindromes.Add(4664, true);
        palindromes.Add(4774, true);
        palindromes.Add(4884, true);
        palindromes.Add(4994, true);

        palindromes.Add(5005, true);
        palindromes.Add(5115, true);
        palindromes.Add(5225, true);
        palindromes.Add(5335, true);
        palindromes.Add(5445, true);
        palindromes.Add(5555, true);
        palindromes.Add(5665, true);
        palindromes.Add(5775, true);
        palindromes.Add(5885, true);
        palindromes.Add(5995, true);

        palindromes.Add(6006, true);
        palindromes.Add(6116, true);
        palindromes.Add(6226, true);
        palindromes.Add(6336, true);
        palindromes.Add(6446, true);
        palindromes.Add(6556, true);
        palindromes.Add(6666, true);
        palindromes.Add(6776, true);
        palindromes.Add(6886, true);
        palindromes.Add(6996, true);

        palindromes.Add(7007, true);
        palindromes.Add(7117, true);
        palindromes.Add(7227, true);
        palindromes.Add(7337, true);
        palindromes.Add(7447, true);
        palindromes.Add(7557, true);
        palindromes.Add(7667, true);
        palindromes.Add(7777, true);
        palindromes.Add(7887, true);
        palindromes.Add(7997, true);

        palindromes.Add(8008, true);
        palindromes.Add(8118, true);
        palindromes.Add(8228, true);
        palindromes.Add(8338, true);
        palindromes.Add(8448, true);
        palindromes.Add(8558, true);
        palindromes.Add(8668, true);
        palindromes.Add(8778, true);
        palindromes.Add(8888, true);
        palindromes.Add(8998, true);

        palindromes.Add(9009, true);
        palindromes.Add(9119, true);
        palindromes.Add(9229, true);
        palindromes.Add(9339, true);
        palindromes.Add(9449, true);
        palindromes.Add(9559, true);
        palindromes.Add(9669, true);
        palindromes.Add(9779, true);
        palindromes.Add(9889, true);
        palindromes.Add(9999, true);

        int reverseNum = D4 * 1000 + D3 * 100 + D2 * 10 + D1; // перевернутое число
        if (num == reverseNum && palindromes.ContainsKey(num)) // если число равно своему перевернутому виду и содержится в словаре
        {
            res = true;
        }
        return res;
    }

    static void Main(string[] args)
    {
        int num = ReadData("Введите проверяемое число:");
        bool isPalindrome = PalTest(num);
        Console.WriteLine("Число {0} является палиндромом? {1}", num, isPalindrome);
    }
}
