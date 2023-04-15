
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.Clear();

int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

string Fibbanachi(int newNum)
{
    string res = String.Empty;
    long first = 0;
    long last = 1;
    for(int i =2 ; i < newNum ; i++)
    {
        res += " "+(first + last);
        (first,last) = (last,first+last);
    }
    return res;
}

string res = "";
int newNum = ReadData("Введите число: ");
res=Fibbanachi(newNum);
Console.WriteLine(res);