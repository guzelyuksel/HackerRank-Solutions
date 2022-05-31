using System;

namespace squares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(squares(100, 1000));
            Console.ReadLine();
        }
        public static int squares(int a, int b)
        {
            int first = (int)Math.Ceiling(Math.Sqrt(a));
            int last = (int)Math.Floor(Math.Sqrt(b));
            return last - first + 1;
        }
    }
}
