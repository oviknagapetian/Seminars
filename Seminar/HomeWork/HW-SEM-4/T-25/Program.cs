// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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

// Решение через цикл MyPow
// long MyPow(int A, int B)
// {
//     long res=1;
//     while(B>0)
//     {
//         res=res*A;
//         B=B-1;
//     }
//     return res;
// }

// Считываем числа и выводим результат
int numA = ReadData ("Введите число A:");
int numB = ReadData ("Введите число B:");
//Console.WriteLine(MyPow(numA,numB)); Решение через цикл MyPow
Console.WriteLine(Math.Pow(numA,numB)); // Решение через функцию  MathPow