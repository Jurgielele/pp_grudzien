using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 0; i <= n; i++)
            {
                int a;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
