using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = birthday(new List<int>() { 2, 2, 1, 3, 2 }, 4, 2);
            //int a = birthday(new List<int>() { 1, 2, 1, 3, 2 }, 3, 2);
            int a = birthday(new List<int>() { 2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4, 2, 1 }, 18, 7);

            Console.WriteLine(a);

            Console.ReadLine();
        }

        public static int birthday(List<int> s, int d, int m)
        {
            int retVal = 0;
            if (s.Count - 1 == 0 && (s[0] == d))
            {
                return ++retVal;
            }
            for (int i = 0; i < s.Count - 1; i++)
            {
                int sum = 0;
                for (int j = i + 1; j < i + m - 1; j++)
                {
                    sum += s[i] + s[j];
                }
                if (sum == d) retVal++;
            }
            return retVal;
        }
    }
}
