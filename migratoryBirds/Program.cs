using System;
using System.Collections.Generic;

namespace migratoryBirds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(migratoryBirds(new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 }));
            Console.ReadLine();
        }



        public static int migratoryBirds(List<int> arr)
        {
            int[] birdTypes = new int[] { 1, 2, 3, 4, 5 };
            int[] typeCounts = new int[] { 0, 0, 0, 0, 0 };
            int retVal = 0;

            foreach (int a in arr)
            {
                typeCounts[a - 1] += 1;
            }
            for (int i = 0; i < typeCounts.Length; i++)
            {
                if (typeCounts[i] > typeCounts[retVal])
                {
                    retVal = i;
                }
            }
            return retVal + 1;
        }
    }
}
