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
            Console.WriteLine("Введите свое значение угла");
            double angle4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Градусные меры углов равны {0},{1},{2},{3}", angle1, angle2, angle3, angle4);

                static double RadianToDegree(double angle)
            {
                return angle * (Math.PI/180);
            }


            double angle12 = RadianToDegree(angle1);

                static double SinRadian(double sinus)
            {
                return sinus = Math.Round(Math.Sin(sinus),3);
            }

            Console.WriteLine("синус угла {0} градусов равен {1}", angle1, SinRadian(angle12));
            

            
            //Console.WriteLine(RadianToDegree(angle1));
            //Console.WriteLine(Math.Round(Math.Sin(RadianToDegree(angle1)), 3));
            //Console.WriteLine(Math.Round(Math.Cos(angle1), 3));

            //Console.WriteLine(Math.Round(Math.Sin(angle2), 3));
            //Console.WriteLine(Math.Round(Math.Cos(angle2), 3));

            //Console.WriteLine(Math.Round(Math.Sin(angle3), 3));
            //Console.WriteLine(Math.Round(Math.Cos(angle3), 3));
            //Console.WriteLine("Введите значение угла");
            //double angle4 = double.Parse(Console.ReadLine());
            //Console.WriteLine(Math.Round(Math.Sin(angle4), 3));
            //Console.WriteLine(Math.Round(Math.Cos(angle4), 3));

            Console.ReadKey();
        }

    }
}

