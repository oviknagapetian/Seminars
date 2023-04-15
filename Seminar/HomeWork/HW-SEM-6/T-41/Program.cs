// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


//Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Подсчёт количества положительных чисел
int CountPosNum(int m)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        int val = ReadData($"Введите число {i + 1}: ");
        if (val > 0) count++;
    }
    return count;
}


int m = ReadData("Введите количество чисел: ");
int posCount = CountPosNum(m);
Console.WriteLine($"Количество положительных чисел: {posCount}");
