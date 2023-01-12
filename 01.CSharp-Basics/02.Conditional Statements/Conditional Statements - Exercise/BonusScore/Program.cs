using System;
using System.Runtime.InteropServices;

namespace BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  INPUT
            int Number = int.Parse(Console.ReadLine());
            // BONUS
            double bonuspoints = 0.0;
            //
            if (Number <= 100)
            {
                bonuspoints = 5;
            }
            else if (Number > 1000)
            {
                bonuspoints = Number * 0.1;
            }
            else
            {
                bonuspoints = Number * 0.2;
            }
            if (Number % 2 == 0)
            {
                bonuspoints = bonuspoints + 1; 
            }
            else if (Number % 10 == 5) // Аз съм малумен :(
            {
                bonuspoints += 2;
            }

            Console.WriteLine(bonuspoints);
            Console.WriteLine(Number + bonuspoints);
            //
            //
            //
        }
    }
}
