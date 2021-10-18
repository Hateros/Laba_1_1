using System;

namespace Laba_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вещественное число:");
            string chisl = Console.ReadLine();
            double x = double.Parse(chisl);
            int d = (int)(x * 10 % (10));
            Console.WriteLine("Первая цифра из дробной части: " + d);
        }
    }
}
