using System;

namespace _6_4_I
{
    class Program
    {
        static ulong F(ulong a) //нерекурсивный метод
        {
            ulong sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                a /= 10;
            }
            return sum;
        }
        static ulong F_Rec(ulong a) //рекурсивный метод
        {
            if (a == 0)
            {
                return 0;
            }
            else
            {
                return F_Rec(a / 10) + a % 10;
            }
        }
        static void Main(string[] args)
        {
            
            Console.Write("n=");
            ulong n = ulong.Parse(Console.ReadLine());
            var startTime = System.Diagnostics.Stopwatch.StartNew();
            ulong sum = F(n);
            startTime.Stop();
            var resultTime = startTime.Elapsed;
            startTime = System.Diagnostics.Stopwatch.StartNew();
            ulong sum_rec = F_Rec(n);
            startTime.Stop();
            var resultTime_rec = startTime.Elapsed;
            Console.WriteLine("Не рекурсивная функция: ", resultTime);
            Console.WriteLine("Рекурсивная функция: ", resultTime_rec);
        }
    }
}
