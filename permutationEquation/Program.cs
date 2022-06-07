using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permutationEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(string.Join("\r\n", permutationEquation(new List<int>() { 2, 3, 1 })));
            Console.ReadLine();
        }

        public static List<int> permutationEquation(List<int> p)
        {
            List<int> result = new List<int>();
            int[] pArray = p.ToArray();
            for (int i = 1; i <= p.Count; i++)
            {
                int index1 = Array.IndexOf(pArray, i) + 1;
                int index2 = Array.IndexOf(pArray, index1) + 1;
                result.Add(index2);
            }
            return result;
        }

    }
}
