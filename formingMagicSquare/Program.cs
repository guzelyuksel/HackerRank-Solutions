using System;
using System.Collections.Generic;
using System.Linq;

namespace formingMagicSquare
{
    internal class Program
    {

        static readonly List<int[][]> possibleSquares = new List<int[][]>()
        {
            new int[][] {
                new int[] {4, 9, 2},
                new int[] {3, 5, 7},
                new int[] { 8, 1, 6 }
            },
            new int[][]
            {
                new int[] {8, 3, 4},
                new int[] {1, 5, 9},
                new int[] {6, 7, 2}
            },
            new int[][] {
                new int[] {6, 1, 8},
                new int[] {7, 5, 3},
                new int[] {2, 9, 4}
            },
            new int[][] {
                new int[] {2, 7, 6},
                new int[] {9, 5, 1},
                new int[] {4, 3, 8}
            },
            new int[][] {
                new int[] {4, 3, 8},
                new int[] {9, 5, 1},
                new int[] {2, 7, 6}
            },
            new int[][] {
                new int[] {6, 7, 2},
                new int[] {1, 5, 9},
                new int[] {8, 3, 4}
            },
            new int[][] {
                new int[] {8, 1, 6},
                new int[] {3, 5, 7},
                new int[] {4, 9, 2}
            },
            new int[][] {
                new int[] {2, 9, 4},
                new int[] {7, 5, 3},
                new int[] {6, 1, 8}
            }
        };

        static void Main(string[] args)
        {

            Console.WriteLine(formingMagicSquare(new List<List<int>>()
            {
                new List<int>(){ 5, 3, 4 },
                new List<int>(){ 1, 5, 8 },
                new List<int>(){ 6, 4, 2 }
            }
            ));
            Console.ReadLine();
        }

        public static int formingMagicSquare(List<List<int>> s)
        {
            List<int> totalCosts = new List<int>();
            int costIndex = 0;
            foreach (int[][] square in possibleSquares)
            {
                totalCosts.Add(0);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        totalCosts[costIndex] += (int)Math.Abs(square[i][j] - s[i][j]);
                    }
                }
                costIndex++;
            }
            return totalCosts.Min();
        }
    }
}
