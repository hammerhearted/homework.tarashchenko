using System;

namespace График
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
        static bool LogicalExpression(double y, double x)
        {
            return x < 1.5 & y > -2;
        }
        static double Input(string name)
        {
            Console.WriteLine("Введите координату " + name);
            return double.Parse(Console.ReadLine());
        }
    }
}


