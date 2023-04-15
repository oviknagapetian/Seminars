// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

using System;

class Program
{
    static int count = 0; // счётчик положительных чисел

    static void Main(string[] args)
    {
        int numPress = ReadData("Введите количество нажатий: ");
        Console.WriteLine("Введите числа:");

        // привязка обработчика к событию
        ConsoleKeyInfo keyPressed;
        Console.TreatControlCAsInput = true;
        while (count < numPress)
        {
            keyPressed = Console.ReadKey(true);
            if (char.IsDigit(keyPressed.KeyChar))
            {
                int num = int.Parse(keyPressed.KeyChar.ToString());
                if (num > 0) count++;
            }
        }
        Console.WriteLine($"\nКоличество введенных положительных чисел: {count}");
    }

    //Ввод числа
    static int ReadData(string msg)
    {
        Console.Write(msg);
        int res = int.Parse(Console.ReadLine() ?? "0");
        return res;
    }
}
