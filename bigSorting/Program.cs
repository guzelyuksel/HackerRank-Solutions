using System;
using System.Collections.Generic;

namespace bigSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string>()
            {
                "31415926535897932384626433832795", "1","3","10","3","5"
            };
            Console.WriteLine(string.Join("\r\n", bigSorting(strList)));
            Console.ReadLine();
        }
        public static List<string> bigSorting(List<string> unsorted)
        {
            unsorted.Sort(delegate (string x, string y)
            {
                if (x.Length > y.Length) return 1;
                else if (x.Length < y.Length) return -1;
                else
                {
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i] > y[i]) return 1;
                        else if (x[i] < y[i]) return -1;
                    }
                    return 0;
                }
            });
            return unsorted;
        }
    }
}
