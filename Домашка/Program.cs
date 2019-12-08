using System;

namespace Квадранты
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение Х");
            var X = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            var Y = int.Parse(Console.ReadLine());
            if (X > 0 & Y > 0)
                Console.WriteLine("точка лежит в 1 квадранте");
            else if (X > 0 & Y < 0)
                Console.WriteLine("точка лежит в 2 квадранте");
            else if (X < 0 & Y < 0)
                Console.WriteLine("точка лежит в 3 квадранте");
            else if (X < 0 & Y > 0)
                Console.WriteLine("точка лежит в 4 квадранте");
            else if (X != 0 & Y == 0)
                Console.WriteLine("точка лежит на оси абсцисс");
            else if (X == 0 & Y != 0)
                Console.WriteLine("точка лежит на оси ординат");
            else
                Console.WriteLine("точка совпадает с началом координат");
            Console.ReadKey();
        }
    }
}
