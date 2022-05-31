using System;
using System.Linq;

namespace camelcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(camelcase("saveChangesInTheEditor"));
            Console.ReadLine();
        }
        public static int camelcase(string s)
        {
            var upperCharsIndex = s.ToCharArray().Where(x => char.IsUpper(x));
            return upperCharsIndex.Count() + 1;
        }
    }
}
