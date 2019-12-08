using System;



namespace Арифметическая_прогрессия__Массивы1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый член арифметической прогрессии");
            var first = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите разность арифметической прогрессии");
            var remainder = int.Parse(Console.ReadLine());

            int[] numbers;
            numbers = new int[10];
            numbers[0] = first;
            numbers[1] = numbers[0] + remainder;
            numbers[2] = numbers[1] + remainder;
            numbers[3] = numbers[2] + remainder;
            numbers[4] = numbers[3] + remainder;
            numbers[5] = numbers[4] + remainder;
            numbers[6] = numbers[5] + remainder;
            numbers[7] = numbers[6] + remainder;
            numbers[8] = numbers[7] + remainder;
            numbers[9] = numbers[8] + remainder;

            for (var i = 0; i < numbers.Length; i++)
                Console.Write("{0} ", numbers[i]);

            Console.ReadKey();
        }
    }
}


