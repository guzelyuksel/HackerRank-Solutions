using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            plusMinus(new List<int> { 1, 1, 0, -1, -1 });

            Console.ReadLine();
        }
        public static void plusMinus(List<int> arr)
        {
            int TotalNumber = arr.Count();
            int PositiveNumbers = 0;
            int NegativeNumbers = 0;
            int ZeroNumbers = 0;
            for (int i = 0; i < TotalNumber; i++)
            {
                if (arr[i] > 0)
                {
                    PositiveNumbers++;
                }
                else if (arr[i] == 0)
                {
                    ZeroNumbers++;
                }
                else if (arr[i] < 0)
                {
                    NegativeNumbers++;
                }
            }
            string First = string.Format("{0:F6}", (decimal)PositiveNumbers / (decimal)TotalNumber);
            string Second = string.Format("{0:F6}", (decimal)NegativeNumbers / (decimal)TotalNumber);
            string Three = string.Format("{0:F6}", (decimal)ZeroNumbers / (decimal)TotalNumber);
            Console.WriteLine(First);
            Console.WriteLine(Second);
            Console.WriteLine(Three);

        }
    }
}
