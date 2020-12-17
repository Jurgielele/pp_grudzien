using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, b=0, sum=0;
            for(int i=0;i<=n; i++)
            {   
                sum = sum + i + 2;
                if (i == 1)
                {
                    sum = sum - 2;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
