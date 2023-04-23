// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

void LineGenRec(int numN)
{
    Console.Write(numN + " ");
    if(numN<=1)
    {

    }
    else
    {
    LineGenRec(numN-1);
    }
}

int num = ReadData("Введите число N: ");
LineGenRec(num);