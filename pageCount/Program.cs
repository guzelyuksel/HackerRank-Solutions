using System;

namespace pageCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(pageCount(4, 4));
            Console.ReadLine();
        }
        public static int pageCount(int n, int p)
        {
            int frontTurn = 0, backTurn = 0;
            if (p > 1)
                frontTurn = p / 2;
            if (n - p > 1)
                backTurn = (n - p) / 2;
            else if (n - p != 0)
                backTurn = n % 2 == 0 ? 1 : 0;
            return Math.Min(frontTurn, backTurn);
        }

    }
}
