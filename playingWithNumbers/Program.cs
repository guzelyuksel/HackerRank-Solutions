using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playingWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Need to be fast..
            var a = playingWithNumbers(new List<int>() { -1, 2, -3 }, new List<int>() { 1, -2, 3 });
            Console.ReadLine();
        }

        public static List<int> playingWithNumbers(List<int> arr, List<int> queries)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < queries.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                   arr[j] += queries[i];
                }
                result.Add(arr.Select(x => Math.Abs(x)).ToList().Sum());
            }
            return result;
        }
    }
}
