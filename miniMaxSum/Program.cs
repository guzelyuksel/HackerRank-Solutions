using System;
using System.Collections.Generic;
using System.Linq;

namespace miniMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hints: Beware of integer overflow! Use 64-bit Integer.
            miniMaxSum(new List<int>() { 256741038, 623958417, 467905213, 714532089, 938071625 });

            Console.ReadLine();
        }

        public static void miniMaxSum(List<int> arr)
        {
            List<long> sumList = new List<long>();
            List<long> longList = arr.ConvertAll(i => (long)i);
            for (int i = 0; i < arr.Count; i++)
            {
                sumList.Add(longList.Sum() - longList[i]);
            }
            Console.WriteLine($"{sumList.Min()} {sumList.Max()}");
        }
    }
}
