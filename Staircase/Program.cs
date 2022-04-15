using System;

namespace Staircase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            staircase(6);
            Console.ReadLine();
        }

        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('#', i + 1).PadLeft(n, ' '));
            }
        }
    }
}
