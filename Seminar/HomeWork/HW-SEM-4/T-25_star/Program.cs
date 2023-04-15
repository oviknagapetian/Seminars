using System;

class Program
{
    static void Main(string[] args)
    {
        // Считываем числа и выбираем операцию
        double num1 = ReadData("Введите число A:");
        char op = ReadOp("Выберите операцию (+, -, *, /, ^):");
        double num2 = ReadData("Введите число B:");
        double result = 0;

        // Выполняем операцию
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                }
                else
                {
                    result = num1 / num2;
                }
                break;
            case '^':
                result = Math.Pow(num1, num2);
                break;
            default:
                Console.WriteLine("Операция не распознана!");
                return; // завершаем выполнение программы, если операция не распознана
        }

        // Выводим результат операции
        Console.WriteLine($"Результат операции: {result}");
    }

    static double ReadData(string message)
    {
        Console.WriteLine(message);
        double res;
        while (!double.TryParse(Console.ReadLine(), out res))
        {
            Console.WriteLine("Ошибка ввода! Введен недопустимый параметр.");
        }
        return res;
    }

    static char ReadOp(string message)
    {
        Console.WriteLine(message);
        char op;
        while (!char.TryParse(Console.ReadLine(), out op) || !IsOperator(op))
        {
            Console.WriteLine("Ошибка ввода! Введена неверная операция.");
        }
        return op;
    }

    static bool IsOperator(char op)
    {
        return op == '+' || op == '-' || op == '*' || op == '/' || op == '^';
    }
}
