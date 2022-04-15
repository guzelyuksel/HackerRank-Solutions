using System;
using System.Collections.Generic;

namespace countApplesAndOranges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            countApplesAndOranges(7, 11, 5, 15, new List<int>() { -2, 2, 1 }, new List<int>() { 5, -6 });
            Console.ReadLine();
        }

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int appleReg = 0;
            int orangeReg = 0;
            for (int i = 0; i < apples.Count; i++)
            {
                int temp = a + apples[i];
                if (temp <= t && temp >= s) appleReg++;
            }
            for (int i = 0; i < oranges.Count; i++)
            {
                int temp = b + oranges[i];
                if (temp <= t && temp >= s) orangeReg++;
            }
            Console.WriteLine(appleReg);
            Console.WriteLine(orangeReg);
        }
    }
}
