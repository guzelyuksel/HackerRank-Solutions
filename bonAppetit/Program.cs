using System;
using System.Collections.Generic;

namespace bonAppetit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bonAppetit(new List<int>() { 3, 10, 2, 9 }, 1, 7);
            Console.ReadLine();
        }
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int totalBill = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                if (i == k) continue;
                totalBill += bill[i];
            }
            int perPersonBill = totalBill / 2;
            if (perPersonBill < b)
            {
                Console.WriteLine(b - perPersonBill);
            }
            else
            {
                Console.WriteLine("Bon Appetit");
            }
        }
    }
}
