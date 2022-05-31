using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utopianTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(utopianTree(5));
            Console.ReadLine();
        }
        public static int utopianTree(int n)
        {
            int treeHeight = 1;
            bool spring = false;
            for (int i = 1; i <= n; i++)
            {
                if (spring)
                {
                    treeHeight++;
                    spring = false;
                }
                else
                {
                    treeHeight *= 2;
                    spring = true;
                }
            }
            return treeHeight;
        }
    }
}
