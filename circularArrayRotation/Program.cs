using System;
using System.Collections.Generic;

namespace circularArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join("\r\n", circularArrayRotation(
                           new List<int>() { 1, 2, 3 }, 2, new List<int>() { 0, 1, 2 }
                       )));
            Console.ReadLine();
        }
        public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {
            a = RightShiftList(a, k);
            List<int> retList = new List<int>();
            foreach (var q in queries)
            {
                retList.Add(a[q]);
            }
            return retList;
        }
        // ref: https://devtut.github.io/csharp/o-n-algorithm-for-circular-rotation-of-an-array.html#example-of-a-generic-method-that-rotates-an-array-by-a-given-shift
        public static List<int> RightShiftList(List<int> a, int totalShift)
        {
            List<int> retList = new List<int>(a);
            for (int i = 0; i < a.Count; i++)
            {
                retList[(i + a.Count + totalShift % a.Count) % a.Count] = a[i];
            }
            return retList;
        }

    }
}
