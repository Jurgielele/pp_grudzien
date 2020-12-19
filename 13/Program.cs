using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args) { 
        int n = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j<n - 1; j++) {
                for (int k = 1; k<n; k++) {
                    if (n - k == j) {
                        Console.Write("X");
                    }
                    else{
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("X");
                }

            for (int l = 0; l<n; l++) {
                Console.Write("X");
            }
        }
    }
 
}
