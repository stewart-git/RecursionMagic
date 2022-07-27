using System;
// Recursion

namespace RecursionMagic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 6; // int.Parse(args[0]);
            mystery(x);
            Console.ReadLine();
        }
        static void mystery(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("Finished");
            }
            else
            {
                Console.WriteLine(n); // going up
                mystery(n - 1);
                Console.WriteLine(n); // going down
            }
        }
    }
}
