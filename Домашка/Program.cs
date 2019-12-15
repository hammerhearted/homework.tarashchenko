using System;

namespace Квадранты
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение Х");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            var y = double.Parse(Console.ReadLine());
            if (x > 0 & y > 0)
                Console.WriteLine("точка лежит в 1 квадранте");
            else if (x > 0 & y < 0)
                Console.WriteLine("точка лежит в 2 квадранте");
            else if (x < 0 & y < 0)
                Console.WriteLine("точка лежит в 3 квадранте");
            else if (x < 0 & y > 0)
                Console.WriteLine("точка лежит в 4 квадранте");
            else if (x != 0 & y == 0)
                Console.WriteLine("точка лежит на оси абсцисс");
            else if (x == 0 & y != 0)
                Console.WriteLine("точка лежит на оси ординат");
            else
                Console.WriteLine("точка совпадает с началом координат");
            Console.ReadKey();
        }
    }
}
