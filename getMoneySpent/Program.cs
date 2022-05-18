using System;

namespace getMoneySpent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getMoneySpent(new int[] { 3, 1 }, new int[] { 5, 2, 8 }, 10));
            Console.ReadLine();
        }

        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int retVal = -1;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    int total = keyboards[i] + drives[j];
                    if (total < b)
                    {
                        if (retVal <= total)
                            retVal = total;
                    }
                }
            }
            return retVal;
        }
    }
}
