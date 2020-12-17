using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int.TryParse(Console.ReadLine(), out a);
            for(int i =1; i<=a; i++)
            {
                Console.WriteLine(i * 7);
            }
        }
    }
}
