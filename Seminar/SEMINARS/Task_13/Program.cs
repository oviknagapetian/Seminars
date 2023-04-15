using System;

class Program {
    static void Main() {
        Console.Write("Введите число: ");
        long number = long.Parse(Console.ReadLine());

        // Вычисляем третью цифру числа
        long thirdDigit = (number / 100) % 10;

        if (thirdDigit == 0) {
            Console.WriteLine("Третьей цифры нет");
        } else {
            Console.WriteLine($"Третья цифра числа: {thirdDigit}");
        }
    }
}
