using System;

namespace SinCos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Градусные меры углов равны {0},{1},{2}", 15, 37, 113);
             
            double angle1 = 15;
            Console.WriteLine(Math.Round(Math.Sin(angle1), 3));
            Console.WriteLine(Math.Round(Math.Cos(angle1), 3));
            double angle2 = 37;
            Console.WriteLine(Math.Round(Math.Sin(angle2), 3));
            Console.WriteLine(Math.Round(Math.Cos(angle2), 3));
            double angle3 = 113;
            Console.WriteLine(Math.Round(Math.Sin(angle3), 3));
            Console.WriteLine(Math.Round(Math.Cos(angle3), 3));
            Console.WriteLine("Введите значение угла");
            double angle4 = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(Math.Sin(angle4), 3));
            Console.WriteLine(Math.Round(Math.Cos(angle4), 3));

            Console.ReadKey();
        }

    }
}

