// Рекурентный метод
// 12345
// 1+2+3+4+5=15

Console.Clear();

//Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

int SumDigRec(int m)
{
    if (m > 0)
    {
        return m % 10 + SumDigRec(m / 10);
    }
    else
    {
        return m;
    }
}  
int M=ReadData("Введите число: ");
int Sum = SumDigRec(M);
Console.Write(Sum);