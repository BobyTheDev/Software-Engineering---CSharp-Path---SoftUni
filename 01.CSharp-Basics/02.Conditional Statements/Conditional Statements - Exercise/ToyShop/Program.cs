using System;
using System.Runtime.CompilerServices;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            double Trip = double.Parse(Console.ReadLine());
            int Puzzle = int.Parse(Console.ReadLine());
            int TalkingDolls = int.Parse(Console.ReadLine());
            int TeddyBear = int.Parse(Console.ReadLine());
            int Minions = int.Parse(Console.ReadLine());
            int Trucks = int.Parse(Console.ReadLine());
            // PRICES
            double PuzzlePrice = 2.60 * Puzzle;
            int TalkingDollPrice = 3 * TalkingDolls;
            double TeddyBearPrice = 4.10 * TeddyBear;
            double MinionPrice = 8.20 * Minions;
            int TruckPrice = 2 * Trucks;
            //Console.WriteLine(PuzzlePrice + TalkingDollPrice + TeddyBearPrice + MinionPrice + TruckPrice); -- DEBUGGER TO TEST IF THE INPUT * PRICES DOES THE JOB (IT DOES)
            double TotalSum = PuzzlePrice + TalkingDollPrice + TeddyBearPrice + MinionPrice + TruckPrice; // CALCULATES Total Price for the customer without discount
            int TotalToys = Puzzle + TalkingDolls + TeddyBear + Minions + Trucks;
            double NewTotalPrice = TotalSum;
            if (TotalToys >= 50)
            {
                NewTotalPrice = TotalSum * 0.75;
            }
            //Console.WriteLine(NewTotalPrice);
            double rent = NewTotalPrice * 0.1;
            //Console.WriteLine(rent1);
            double profit = NewTotalPrice - rent;
            if (profit >= Trip)
            {
                double moneyaftertrip = profit - Trip;
                Console.WriteLine("Yes! {0:F2} lv left.", moneyaftertrip);
            }
            else
            {
                double notenough = Trip - profit;
                Console.WriteLine("Not enough money! {0:F2} lv needed.", notenough);
            }
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(Trip);
            //Console.WriteLine(profit);
            //Console.WriteLine(notenough);
            // DEBUGGING STUFF I USED
        }
    }
}
