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

            double RadianToDegree(double angle)
            {
                return angle * (Math.PI/180);
            }


            double angle12 = RadianToDegree(angle1);
            double angle22 = RadianToDegree(angle2);
            double angle32 = RadianToDegree(angle3);
            double angle42 = RadianToDegree(angle4);

             double SinRadian(double sinus)
            {
                 return Math.Round(Math.Sin(sinus),3);
              
            }

             double CosRadian(double cosinus)
            {
                return Math.Round(Math.Cos(cosinus), 3);
            }

            /*void WriteResult(double defaultangle, double sin, double cos)
            {
               Console.WriteLine("синус угла {0} градусов равен {1}, косинус равен {2}", defaultangle, SinRadian(sin), CosRadian(cos));
                return;
            }

            Console.WriteLine((WriteResult(angle1, angle12, angle12)));*/
            Console.WriteLine("синус угла {0} градусов равен {1}, косинус равен {2}", angle1, SinRadian(angle12), CosRadian(angle12));
            Console.WriteLine("синус угла {0} градусов равен {1}, косинус равен {2}", angle2, SinRadian(angle22), CosRadian(angle22));
            Console.WriteLine("синус угла {0} градусов равен {1}, косинус равен {2}", angle3, SinRadian(angle32), CosRadian(angle32));
            Console.WriteLine("синус угла {0} градусов равен {1}, косинус равен {2}", angle4, SinRadian(angle42), CosRadian(angle42));


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

