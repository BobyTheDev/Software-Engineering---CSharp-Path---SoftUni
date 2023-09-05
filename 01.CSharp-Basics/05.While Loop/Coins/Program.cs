using System;
using System.Diagnostics.CodeAnalysis;

namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double changeToReturn = double.Parse(Console.ReadLine());
            int coins = 0;

            while (changeToReturn > 0)
            {
                changeToReturn = Math.Round(changeToReturn, 2);

                if (changeToReturn >= 3)
                {
                    changeToReturn -= 2;
                    coins++;
                }
                else if (changeToReturn >= 2)
                {
                    changeToReturn -= 2; coins++;
                }
                else if (changeToReturn >= 1) { changeToReturn -= 1; coins++; }
                else if (changeToReturn >= 0.50) { changeToReturn -= 0.50; coins++; }
                else if (changeToReturn >= 0.20) { changeToReturn -= 0.20; coins++; }
                else if (changeToReturn >= 0.10) { changeToReturn -= 0.10; coins++; }
                else if (changeToReturn >= 0.05) { changeToReturn -= 0.05; coins++; }
                else if (changeToReturn >= 0.02) { changeToReturn -= 0.02; coins++; }
                else if (changeToReturn >= 0.01) { changeToReturn -= 0.01; coins++; }

            }
            Console.WriteLine(coins);
        }
    }
}
