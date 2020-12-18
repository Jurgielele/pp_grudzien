using System;

namespace _14
{
    class Program
    {
        static void Main()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int a = arr[0];
            int b = arr[1];
            for (int i = a; i <= b - 2; i++)
                for (int j = i + 1; j <= b - 1; j++)
                    for (int k = j + 1; k<= b; k++)
                        if (i*i + j * j == k * k)
                            Console.WriteLine("{0} {1} {2}", i, j, k);
        }
    }
}
