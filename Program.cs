using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону квадрата: ");
            int a = int.Parse(Console.ReadLine());
            int P = 4 * a;
            int S = a * a;
            Console.WriteLine($"Периметр = {P}\nПлощадь = {S}");
        }
    }
}
