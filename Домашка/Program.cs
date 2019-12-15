using System;

namespace Трапеция
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("введите высоту");
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine("введите большее основание");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("введите меньшее основание");
            var c = double.Parse(Console.ReadLine());
            double s = h * (c + b) / 2;
            Console.WriteLine("Площадь трапеции равна = ");
            Console.WriteLine(s);
            double a = (b - c) / 2;
            double d = Math.Sqrt((a * a) - (h * h));
            double p = (d * 2) + b + c;
            Console.WriteLine("Периметр трапеции равен = ");
            Console.WriteLine(p);
            Console.ReadKey();

        }
    }
}

