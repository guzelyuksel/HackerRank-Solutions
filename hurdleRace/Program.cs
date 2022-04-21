using System;
using System.Collections.Generic;
using System.Linq;

namespace hurdleRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(hurdleRace(7, new List<int>() { 2, 5, 4, 5, 2 }));
        }
        public static int hurdleRace(int k, List<int> height)
        {
            if (k > height.Max())
            {
                return 0;
            }

            return Math.Abs(height.Max() - k);
        }
    }
}
