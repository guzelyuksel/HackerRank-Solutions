using System;
using System.Collections.Generic;

namespace divisibleSumPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(divisibleSumPairs(6, 3, new List<int>() { 1, 3, 2, 6, 1, 2 }));
            Console.ReadLine();
        }

        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int retVal = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        retVal++;
                    }
                }
            }
            return retVal;
        }
    }
}
