using System;
using System.Collections.Generic;
using System.Linq;

namespace birthdayCakeCandles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(birthdayCakeCandles(new List<int>() { 3, 2, 1, 3 }));
            Console.ReadLine();
        }

        public static int birthdayCakeCandles(List<int> candles)
        {
            int retCount = 0;
            int maxHeight = candles.Max();
            retCount = candles.Where(x => x == maxHeight).Count();
            return retCount;
        }
    }
}
