// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();

// Ввод числа
int ReadData(string msg)
{
Console.Write(msg);
int res = int.Parse(Console.ReadLine() ?? "0");
return res;
}

// Рекурсивная функция для вычисления суммы натуральных чисел в промежутке от m до n
int SumInRange(int m, int n)
{
if (m > n) // Если m больше n, то возвращаем 0
{
return 0;
}
else
{
return m + SumInRange(m + 1, n); // Иначе, складываем m с результатом вызова функции для интервала от m+1 до n
}
}

// Чтение значений m и n, вызов функции и вывод результата
int m = ReadData("Введите начальное значение M: ");
int n = ReadData("Введите конечное значение N: ");
int sum = SumInRange(m, n);
Console.WriteLine("Сумма натуральных чисел в промежутке от " + m + " до " + n + " равна " + sum + ".");