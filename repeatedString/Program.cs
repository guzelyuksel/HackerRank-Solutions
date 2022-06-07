using System;
using System.Linq;

namespace repeatedString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(repeatedString("abcac", 10));
            Console.ReadLine();
        }
        public static long repeatedString(string s, long n)
        {
            var multiplier = n / s.Length; // kaç adet s tekrar edebilir
            var remainer = n % s.Length; // bölümden geriye kalan s uzunluğu
            return multiplier * s.Count(c => c == 'a') + s.Substring(0, (int)remainer).Count(c => c == 'a');
            // tekrar eden s * s içindeki a sayısı + bölümden geriye kalan s içindeki a sayısı
        }
    }
}