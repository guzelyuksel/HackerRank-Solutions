using System;
using System.Collections.Generic;

namespace insertionSort1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            insertionSort1(5, new List<int>() { 1, 2, 4, 5, 3 });
            Console.ReadLine();
        }
        public static void insertionSort1(int n, List<int> arr)
        {
            int i = n - 1;
            int tempVal = arr[i];
            while (i > 0 && tempVal < arr[i - 1])
            {
                arr[i] = arr[i - 1];
                Console.WriteLine(string.Join(" ", arr));
                i--;
            }
            arr[i] = tempVal;
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
