using System;
using System.Collections.Generic;
using System.Linq;

namespace climbingLeaderboard
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> rankedList = new List<int>() { 100, 100, 50, 40, 40, 20, 10 };
            List<int> playerList = new List<int>() { 5, 25, 50, 120 };

            List<int> list = climbingLeaderboard(rankedList, playerList);
            Console.WriteLine(String.Join("\r\n", list));
            Console.ReadLine();
        }
        // limit ex.
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> result = new List<int>();
            int playerIndex = 0;
            for (int i = 0; i < player.Count; i++)
            {
                if (i == 0)
                {
                    ranked.Add(player[i]);
                }
                else
                {
                    ranked[playerIndex] = player[i];
                }
                ranked.Sort();
                ranked.Reverse();
                result.Add(ranked.Distinct().ToList().LastIndexOf(player[i]) + 1);
                playerIndex = ranked.LastIndexOf(player[i]);
            }
            return result;
        }
    }
}
