using System;

namespace beautifulDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(beautifulDays(20, 23, 6));
            Console.ReadLine();
        }
        public static int beautifulDays(int i, int j, int k)
        {
            int count = 0;
            for (int a = i; a <= j; a++)
            {
                if (Math.Abs(a - ReverseInt(a)) % k == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int ReverseInt(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }
    }
}
