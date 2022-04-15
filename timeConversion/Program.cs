using System;

namespace timeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(timeConversion("06:40:03AM"));
            Console.ReadLine();
        }

        public static string timeConversion(string s)
        {
            string newTime;
            string[] times = s.Split(new char[] { ':' });
            if (times[2].Contains("PM") && times[0] != "12")
            {
                newTime = $"{Convert.ToString(Convert.ToInt32(times[0]) + 12).PadLeft(2, '0')}:{times[1]}:{times[2].Replace("AM", "").Replace("PM", "")}";
            }
            else if (times[2].Contains("AM") && times[0] == "12")
            {
                newTime = $"00:{times[1]}:{times[2].Replace("AM", "").Replace("PM", "")}";
            }
            else
            {
                newTime = $"{Convert.ToString(Convert.ToInt32(times[0])).PadLeft(2, '0')}:{times[1]}:{times[2].Replace("AM", "").Replace("PM", "")}";
            }
            return newTime;
        }
    }
}
