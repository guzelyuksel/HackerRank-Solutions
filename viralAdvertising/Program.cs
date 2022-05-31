using System;

namespace viralAdvertising
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(viralAdvertising(3));
            Console.ReadLine();
        }
        public static int viralAdvertising(int n)
        {
            double totalLikes = 0D;
            double AdShareCount = 5.0;
            for (int i = 0; i < n; i++)
            {
                totalLikes += Math.Floor(AdShareCount / 2);
                AdShareCount = Math.Floor(AdShareCount / 2) * 3;
            }
            return (int)totalLikes;
        }
    }
}
