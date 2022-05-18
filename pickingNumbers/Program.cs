using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pickingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(pickingNumbers(new List<int>() { 1, 2, 2, 3, 1, 2 }));
            Console.ReadLine();
        }

        public static int pickingNumbers(List<int> a)
        {
            int count = 0;
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (Math.Abs(a[i] - a[j]) <= 1)
                    {
                        count++;
                    }
                }
            }
            return count; ;
        }
    }
}
