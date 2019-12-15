using System;

namespace SinCos
{
    class Program
    {
        static void Main(string[] args)
        {
            double angle1 = 15;
            double angle2 = 37;
            double angle3 = 113;

            Console.WriteLine("Градусные меры углов равны {0},{1},{2}", angle1, angle2, angle3);
            static double Rad (double angle1, double angle2, double angle3)
            {

            }
           
            Console.WriteLine(Math.Round(Math.Sin(angle1), 3));
            Console.WriteLine(Math.Round(Math.Cos(angle1), 3));
            
            Console.WriteLine(Math.Round(Math.Sin(angle2), 3));
            Console.WriteLine(Math.Round(Math.Cos(angle2), 3));
            
            Console.WriteLine(Math.Round(Math.Sin(angle3), 3));
            Console.WriteLine(Math.Round(Math.Cos(angle3), 3));
            Console.WriteLine("Введите значение угла");
            double angle4 = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(Math.Sin(angle4), 3));
            Console.WriteLine(Math.Round(Math.Cos(angle4), 3));

            Console.ReadKey();
        }

    }
}

