using System;
using System.Collections.Generic;
using System.Linq;

namespace kaprekarNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kaprekarNumbers(1, 100);
            Console.ReadLine();
        }
        public static void kaprekarNumbers(int p, int q)
        {
            List<int> result = new List<int>();
            for (int i = p; i < q + 1; i++)
            {
                if (CheckKaprekar(i))
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(!result.Any() ? "INVALID RANGE" : string.Join(" ", result));
        }

        public static bool CheckKaprekar(int i)
        {
            int digits = (int)Math.Floor(Math.Log10(i) + 1);
            double sqrt = Math.Pow(i, 2);
            double rightDigits = sqrt % Math.Pow(10, digits);
            double leftDigits = sqrt / Math.Pow(10, digits);
            return (int)(rightDigits + leftDigits) == i;
        }
    }
}
