using System;

namespace saveThePrisoner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(saveThePrisoner(5, 2, 1));
            Console.WriteLine(saveThePrisoner(5, 2, 2));
            Console.ReadLine();
        }
        public static int saveThePrisoner(int numberOfPrisoners, int numberOfSweets, int prisonerId)
        {
            var remainingPrisonersBeforeEnd = numberOfPrisoners - prisonerId + 1;
            if (numberOfSweets > remainingPrisonersBeforeEnd)
            {
                prisonerId = 1;
                numberOfSweets -= remainingPrisonersBeforeEnd;
                numberOfSweets %= numberOfPrisoners;
            }
            if (numberOfSweets == 0)
                prisonerId = numberOfPrisoners;
            else
                prisonerId += numberOfSweets - 1;
            return prisonerId;
        }
    }
}
