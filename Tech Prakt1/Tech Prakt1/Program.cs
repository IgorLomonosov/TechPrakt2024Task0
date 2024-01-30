using System;

namespace TechPrakt
{
    class Program
    {
        static double Sum(double x, double y)
        {
            return x + y;
        }
        public static void Main()
        {
            Console.WriteLine("Введіть перше число для обчислення:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть друге число для обчислення:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Сума двох введених чисел: {Sum(x, y)}");
        }
    }
}