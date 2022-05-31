using System;
using System.Collections.Generic;
using System.Linq;

namespace insertionSort1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            insertionSort1(14, new List<int>() { 1, 3, 5, 9, 13, 22, 27, 35, 46, 51, 55, 83, 87, 23 });
            Console.ReadLine();
        }
        public static void insertionSort1(int n, List<int> arr)
        {
            int last = arr[n - 2];
            int temp = arr[n - 1];
            int i = n - 1;
            while (true)
            {
                if (n >= 0)
                {

                }
                i--;
            }
        }
    }
}
