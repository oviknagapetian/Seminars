// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Функция ReadData считывает целое число с консоли и возвращает его.
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

//Метод находит расстояние расстояния между двумя точками в трехмерном пространстве 
double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

// Считываем координаты и выводим результат
int x1 = ReadData ("Введите координату x точки A:");
int y1 = ReadData ("Введите координату y точки A:");
int z1 = ReadData ("Введите координату z точки A:");

int x2 = ReadData ("Введите координату x точки B:");
int y2 = ReadData ("Введите координату y точки B:");
int z2 = ReadData ("Введите координату z точки B:");

Console.WriteLine("Расстояние между точками: " + Distance3D(x1,y1,z1,x2,y2,z2));