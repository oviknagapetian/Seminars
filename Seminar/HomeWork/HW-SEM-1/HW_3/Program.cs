using System;

class Program {
  static void Main(string[] args) {
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());

    if (num % 2 == 0) {
      Console.WriteLine("Число является чётным.");
    } else {
      Console.WriteLine("Число не является чётным.");
    }
  }
}
