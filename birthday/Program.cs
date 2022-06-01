using System;
using System.Collections.Generic;
using System.Linq;

namespace birthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(birthday(new List<int>() { 2, 2, 1, 3, 2 }, 4, 2));
            Console.ReadLine();
        }
        public static int birthday(List<int> s, int d, int m)
        {
            int totalCount = 0;
            for (int i = 0; i < s.Count() - (m - 1); i++)
            {
                if (s.Skip(i).Take(m).Sum() == d)
                {
                    totalCount++;
                }
            }
            return totalCount;
        }
    }
}
