using System;
using System.Collections.Generic;
using System.Linq;

namespace sockMerchant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = sockMerchant(9, new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
            Console.WriteLine(a);
            Console.ReadLine();
        }
        public static int sockMerchant(int n, List<int> ar)
        {
            return ar.GroupBy(x => x).Where(x => x.Count() >= 2).Select(z => z.Count() / 2).Sum();
        }
    }
}
