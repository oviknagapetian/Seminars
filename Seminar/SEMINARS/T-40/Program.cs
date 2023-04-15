
// Задача No40
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.



// Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод проверки существования треугольника
void Triangle(int a, int b, int c)
{
    if (a > 0 && b > 0 && c > 0) // Проверка на положительность сторон
    {
        if (a < (b + c) && b < (a + c) && c < (a + b))
        {
            Console.WriteLine("Треугольник существует");
        }
        else
        {
            Console.WriteLine("Треугольник не существует");
        }
    }
    else
    {
        Console.WriteLine("Длины сторон должны быть положительными числами");
    }
}

// Задаем стороны
int a = ReadData("Введите первую сторону: ");
int b = ReadData("Введите вторую сторону: ");
int c = ReadData("Введите третью сторону: ");

// Проверяем
Triangle(a, b, c);
