using System;

namespace cSHARPlab1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            { 
                double d = 3.14 / 2;
                double summ = 0;

                Console.WriteLine("Введите значение n:");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Вы ввели неверное значение!");
                    break;
                }

                Console.WriteLine("Введите значение x:");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x > 1)
                {
                    Console.WriteLine("Вы ввели неверное значение!");
                    break;
                }

                for (int j = 0; j <= n; j++)
                {
                    double arcctgx = (Math.Pow(-1, n + 1)) * (Math.Pow(x, 2 + n + 1)) / 2 * n + 1;
                    summ = summ + arcctgx;
                }

                d = summ + d;

                Console.WriteLine($"Результат выражения: {d}");
            }
        }
    }
}
