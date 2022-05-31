using System;
using System.Collections.Generic;
using System.Linq;

namespace angryProfessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(angryProfessor(3, new List<int>() { -1, -3, 4, 2 }));
            Console.WriteLine(angryProfessor(2, new List<int>() { 0, -1, 2, 1 }));

            Console.ReadLine();
        }
        public static string angryProfessor(int k, List<int> a)
        {
            int negativeNumbers = a.Where(x => x <= 0).Count();
            return (negativeNumbers < k) ? "YES" : "NO";
        }
    }
}
