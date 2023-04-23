// 69 Напишите прграмму, которая будет принимать 2 числа А и В
// возыедите А в степень В с помощью рекурсии

Console.Clear();

//Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// первый метод
long RecPow(int a, int b)
{
    if (b > 0)
    {
        return a * RecPow(a, b - 1);
    }
    else
    {
        return 1;
    }
}

// второй метод
long MyRecPow(int a, int b)
{
    if (b == 2)
    {
        return 4;
    }
    else
    {
       return RecPow(a, b / 2)*RecPow(a, b / 2);
    }
}

int A = ReadData("Введите число a: ");
int B = ReadData("Введите число b: ");

// DateTime d1 = DateTime.Now;
// RecPow(A,B);
// Console.WriteLine("Решение RecPow:" + (DateTime.Now - d1));

// DateTime d2 = DateTime.Now;
// MyRecPow(A,B);
// Console.WriteLine("Решение MyRecPow:" + (DateTime.Now - d2));

long PowAB = MyRecPow(A, B);
Console.WriteLine(PowAB);