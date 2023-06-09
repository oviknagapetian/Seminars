﻿// Дополнительно: Написать программу которая из имен через запятую выберет случайное
// имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора
// случайного имени метод Random.Next(1,<длина массива имен>+1).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите имена через запятую:"); // Выводим сообщение на консоль, запрашивая ввод имен через запятую
        string? namesString = Console.ReadLine(); // Считываем введенную строку и сохраняем ее в переменную namesString типа string

        if (string.IsNullOrWhiteSpace(namesString)) // Проверяем, является ли строка пустой или содержит только пробелы
        {
            Console.WriteLine("Строка имен пуста или содержит только пробелы."); // Если строка пуста или содержит только пробелы, выводим сообщение об ошибке и завершаем программу
            return;
        }

        string[] names = namesString.Split(','); // Разбиваем строку имен на отдельные имена по разделителю ","

        Random random = new Random();// Создаем новый экземпляр класса Random для генерации случайного числа
        int index = random.Next(1, names.Length+1);// Генерируем случайный индекс от 0 до (длина массива имен - 1)

        Console.WriteLine($"Выбрано имя: {names[index].Trim()}");// Выводим на консоль выбранное случайным образом имя, удаляя возможные пробелы в начале и конце
    }
}
