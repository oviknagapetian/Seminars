using System;

class Program
{
    static void Main(string[] args)
    {
        // Вводим исходный массив строк
        Console.Write("Введите строку, содержащую элементы массива, разделенные пробелом: ");
        string input = Console.ReadLine() ?? "";
        string[] source = input.Split(' ');
        // Создаем массив для хранения результата
        string[] result = new string[source.Length];
        int count = 0;

        // Перебираем элементы исходного массива и копируем те, у которых длина <= 3
        for (int i = 0; i < source.Length; i++)
        {
            if (source[i].Length <= 3)
            {
                result[count] = source[i];
                count++;
            }
        }

        // Создаем новый массив с длиной, соответствующей количеству скопированных элементов
        string[] finalResult = new string[count];
        Array.Copy(result, finalResult, count);

        // Выводим результат
        Console.WriteLine("Результат:");
        Console.WriteLine(string.Join(", ", finalResult));
    }
}