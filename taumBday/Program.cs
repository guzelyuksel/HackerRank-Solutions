using System;
using System.Numerics;

namespace taumBday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(taumBday(10,10,1,1,1));
            Console.ReadLine();
        }
        public static long taumBday(int b, int w, int bc, int wc, int z)
        {
            BigInteger bigIntB = new BigInteger(b);
            BigInteger bigIntW = new BigInteger(w);
            return (long)(bigIntB * new BigInteger(Math.Min(bc, wc + z)) + bigIntW * new BigInteger(Math.Min(wc, bc + z)));
        }
    }
}
