using System;
using System.Collections.Generic;
using System.Linq;

namespace minimumDistances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(minimumDistances(new List<int>() { 7, 1, 3, 4, 1, 7 }));
            Console.ReadLine();
        }
        public static int minimumDistances(List<int> a)
        {
            List<int> resList = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (Math.Abs(a[i] - a[j]) == 0)
                    {
                        resList.Add(Math.Abs(i - j));
                    }
                }
            }
            return resList.Count == 0 ? -1 : resList.Min();
        }
    }
}
