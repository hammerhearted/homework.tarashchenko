using System;

namespace Задача1Труъ
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Input("x");
            var y = Input("y");
            Console.WriteLine("Значение выражения: " + LogicalExpression(x, y));
            Console.ReadKey();
        }
        static bool LogicalExpression(int x, int y)
        {
            return (x < 20) ^ (y < 20);
        }
        static int Input(string name)
        {
            Console.WriteLine("Введите число " + name);
            return int.Parse(Console.ReadLine());
        }
    }
}