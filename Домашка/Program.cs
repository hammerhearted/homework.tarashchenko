using System;

namespace Трапеция
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("введите высоту");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("введите большее основание");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("введите меньшее основание");
            int c = int.Parse(Console.ReadLine());
            int s = h * (c + b) / 2;
            Console.WriteLine("Площадь трапеции равна = ");
            Console.WriteLine(s);
            int a = (b - c) / 2;
            double d = Math.Sqrt((a * a) - (h * h));
            double p = (d * 2) + b + c;
            Console.WriteLine("Периметр трапеции равен = ");
            Console.WriteLine(p);
            Console.ReadKey();

        }
    }
}

