using System;
using System.Collections.Generic;

namespace designerPdfViewer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(designerPdfViewer(new List<int>() { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, "abc"));
            Console.ReadLine();
        }
        public static int designerPdfViewer(List<int> h, string word)
        {
            int max = 0;
            foreach (char c in word)
            {
                int b = h[c - 'a'];
                if (b > max) max = b;
            }
            return max * word.Length;
        }
    }
}
