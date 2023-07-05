using System;
namespace TwinPrime
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long max = 0;
            while (max == 0)
                try
                {
                    Console.WriteLine("Enter max value.");
                    max = long.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            Console.Clear();
            DateTime Start = DateTime.Now;
            int primeTmp = 2;
            for (int num = 3; num <= max; num++)
            {
                if (num % 2 == 0)
                    continue;
                double sqrtNum = Math.Sqrt(num);
                for (int i = 3; i <= sqrtNum; i += 2)
                    if (num % i == 0)
                        goto PRIME;
                if (num - primeTmp == 2)
                {
                    Console.Write(primeTmp);
                    Console.Write(",");
                    Console.WriteLine(num);
                }
                primeTmp = num;
            PRIME:;
            }
            Console.WriteLine("\n-------------------------end-------------------------");
            Console.Write("max:");
            Console.Write(max);
            Console.Write("  running time:");
            Console.Write((DateTime.Now - Start).TotalSeconds);
            Console.WriteLine("s");
            Console.ReadKey();
        }
    }
}