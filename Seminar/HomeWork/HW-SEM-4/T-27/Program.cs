// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Функция ReadData считывает целое число с консоли и возвращает его
int ReadData(string message)
{ 
    Console.WriteLine(message); 
    int res;
    while(!int.TryParse(Console.ReadLine(), out res))
    {
        Console.WriteLine("Ошибка ввода! Введен недопустимый параметр.");
    }
    return res;
}
// Альтернативное решение
// int num = ReadData("Введите число:"); // используем функцию ReadData из предыдущего примера
// int sum = 0;

// while (num != 0)
// {
//     sum += num % 10; // находим последнюю цифру числа и добавляем ее к сумме
//     num /= 10; // удаляем последнюю цифру из числа
// }
// Console.WriteLine($"Сумма цифр числа: {sum}");


// Считаем сумму чисел с помощью метода SumSimple
long SumSimple(long num)
{
    long sum = 0;
    while (num != 0)
    {
        sum += num % 10; // находим последнюю цифру числа и добавляем ее к сумме
        num /= 10; // удаляем последнюю цифру из числа
    }   
    return sum;
}
long num = ReadData("Введите число:"); // используем функцию ReadData из предыдущего примера

Console.WriteLine(SumSimple(num));
