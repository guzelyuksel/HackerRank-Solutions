using System;

namespace findDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findDigits(124));
            Console.WriteLine(findDigits(111));
            Console.WriteLine(findDigits(10));
            Console.ReadLine();
        }
        public static int findDigits(int n)
        {
            int retVal = 0;
            foreach (char charVal in n.ToString())
            {
                if (charVal == '0') continue;
                if (n % (int)char.GetNumericValue(charVal) == 0) retVal++;
            }
            return retVal;
        }
    }
}
