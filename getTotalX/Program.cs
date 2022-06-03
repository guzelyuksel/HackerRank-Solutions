using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getTotalX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getTotalX(new List<int>() { 2, 6 }, new List<int>() { 24, 36 }));
            Console.ReadLine();
        }

        public static int getTotalX(List<int> a, List<int> b)
        {
            int retVal = 0;
            for (int i = a.Max(); i <= b.Min(); i += a.Max())
            {
                if (a.FirstOrDefault(x => (i % x != 0 && x != 0)) == 0 &&
                    b.FirstOrDefault(x => (x % i != 0 && x != 0)) == 0)
                {
                    retVal++;
                }
            }
            return retVal;
        }

    }
}
