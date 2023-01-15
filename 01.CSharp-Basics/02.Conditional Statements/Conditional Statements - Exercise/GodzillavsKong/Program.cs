using System;

namespace GodzillavsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT SYSTEM = DOUBLE BUDGETMOVIE; INT ACTORS; DOUBLE PRICE FOR CLOTHES
            double Budget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double PriceClothes = double.Parse(Console.ReadLine());
            // Decor is 10% of Budget
            double PriceDecor = Budget * 0.10;
            // IF > 150 10% DISCOUNT FOR CLOTHES
            if (actors > 150)
            {
                PriceClothes = PriceClothes - PriceClothes * 0.1;
            }
            double TotalClothesPrice = PriceClothes * actors;
            double BudgetDifference = Budget - (TotalClothesPrice + PriceDecor);
            if (BudgetDifference >= 0) 
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {BudgetDifference:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(BudgetDifference):f2} leva more.");
            }
        }
    }
}
