// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых

Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите значение b3: ");
double b3 = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите значение k3: ");
double k3 = double.Parse(Console.ReadLine() ?? "0");

// Найдём координаты точек пересечения двух прямых:
// y = k1 * x + b1 и y = k2 * x + b2
double x1 = (b2 - b1) / (k1 - k2);
double y1 = k1 * x1 + b1;
double x2 = (b3 - b1) / (k1 - k3);
double y2 = k1 * x2 + b1;

// Найдём координаты третьей точки пересечения прямой y = k3 * x + b3 с прямой, проходящей через точки (x1, y1) и (x2, y2):
double x3 = (y2 - b3 + k3 * x2 - k3 * x1) / (k3 - k1);
double y3 = k3 * x3 + b3;

// Найдём площадь треугольника через формулу Герона, используя расстояния между точками пересечения прямых:
double a = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
double b = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
double p = (a + b + c) / 2;
double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

Console.WriteLine($"Точка пересечения прямых: ({x1}, {y1}), ({x2}, {y2}), ({x3}, {y3})");
Console.WriteLine($"Площадь треугольника: {S}");