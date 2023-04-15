// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//  метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

string DecToBin (int num)
{
string res = String.Empty;
while(num>0)
{
    res+=num%2;
    num=num/2;
}

return res;
}

string res=0;
int a =  ReadData ("Введите А");
res = DecToBin(a);
Console.WriteLine(res);