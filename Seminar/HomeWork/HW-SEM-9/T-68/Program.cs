// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

//Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Вычисление значения функции Аккермана
int Ackermann(int m, int n)
{
if (m == 0) //если m = 0, возвращаем n + 1
{
return n + 1;
}
else if (n == 0) //если n = 0, вызываем функцию Ackermann(m-1,1)
{
return Ackermann(m - 1, 1);
}
else //в остальных случаях вызываем функцию Ackermann(m-1,Ackermann(m,n-1))
{
return Ackermann(m - 1, Ackermann(m, n - 1));
}
}

//Вводим значения для m и n
int m = ReadData("Введите число m: ");
int n = ReadData("Введите число n: ");

//Вычисляем значение функции Аккермана для m и n
int result = Ackermann(m, n);

//Выводим результат
Console.WriteLine("A(" + m + "," + n + ") = " + result);