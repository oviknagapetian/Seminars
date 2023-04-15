internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        int max = a > b ? a : b;
        int min = a < b ? a : b;

        Console.WriteLine($"Наибольшее число: {max}");
        Console.WriteLine($"Наименьшее число: {min}");
    }
}