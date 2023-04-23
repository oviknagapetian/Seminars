using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Введите трёхзначное число:");
        int number = int.Parse(Console.ReadLine()); // получаем число от пользователя

        int secondDigit = (number / 10) % 10; // вычисляем вторую цифру числа

        Console.WriteLine($"Вторая цифра числа {number} равна {secondDigit}");
        Console.ReadKey(); // ожидаем нажатия клавиши для завершения программы
    }
}