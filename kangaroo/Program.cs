using System;

namespace kangaroo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(kangaroo(0, 3, 4, 2));
            Console.ReadLine();
        }

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            // (y * v1) + x1 = (y * v2) + x2 => y = jump count
            string retVal = "NO";
            if ((x2 - x1) * (v2 - v1) < 0 && (x2 - x1) % (v2 - v1) == 0)
            {
                retVal = "YES";
            }
            return retVal;
        }
    }
}
