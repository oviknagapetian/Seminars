// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом


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
// Функция LineGen генерирует строку с квадратами чисел от 1 до num, возведенными в степень pow.
string LineGen(int num, int pow)
{
    string res = "";
    for (int i = 1; i<=num; i++)
    {
        res+=Math.Pow(i, pow)+" "; 
    }
    return res;
}
// Считываем число N и выводим результат
int numN = ReadData ("Введите число N:");
Console.WriteLine(LineGen(numN,1));
Console.WriteLine(LineGen(numN,3));