using System;

namespace countingValleys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countingValleys(8, "UDDDUDUU"));
            Console.ReadLine();
        }

        public static int countingValleys(int steps, string path)
        {
            int firstX = 0, seaLevel = 0;
            int i = 0;
            while (i < path.Length)
            {
                if (path[i] == 'U') firstX++;
                if (path[i] == 'D') firstX--;
                if (path[i] == 'U' && firstX == 0) seaLevel++;
                i++;
            }
            return seaLevel;
        }
    }
}
