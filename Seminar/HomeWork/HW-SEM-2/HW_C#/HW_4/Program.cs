using System;

class Program {
  static void Main(string[] args) {
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Чётные числа от 1 до N: ");
    for (int i = 2; i <= n; i += 2) {
      Console.Write(i + " ");
    }
    Console.WriteLine();
  }
}
