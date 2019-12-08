using System;

namespace задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес электронной почты");
            string yourMail = Console.ReadLine();
            int position = yourMail.IndexOf("@");
            Console.WriteLine("Ваш почтовый ящик " + yourMail.Substring(0, position) + " находится на почтовом сервисе " + (yourMail.Substring(position + 1)));
            Console.ReadKey();

        }
    }
}
