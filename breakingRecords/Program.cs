using System;
using System.Collections.Generic;

namespace breakingRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = breakingRecords(new List<int>() { 12, 24, 10, 24 });
            Console.ReadLine();
        }

        public static List<int> breakingRecords(List<int> scores)
        {
            List<int> retList = new List<int>();

            int max = scores[0];
            int min = scores[0];

            int countMax = 0;
            int countMin = 0;
            foreach (int score in scores)
            {
                if (score > max)
                {
                    max = score;
                    countMax++;
                }
                if (score < min)
                {
                    min = score;
                    countMin++;
                }
            }
            retList.Add(countMax);
            retList.Add(countMin);

            return retList;
        }
    }
}
