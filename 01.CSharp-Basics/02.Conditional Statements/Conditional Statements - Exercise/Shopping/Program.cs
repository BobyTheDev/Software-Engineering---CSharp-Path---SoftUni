using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PRICE
            int video_cards = 250;
            // INPUT
            double PeterBudget = double.Parse(Console.ReadLine());
            int bought_video_cards = int.Parse(Console.ReadLine());
            int bought_cpus = int.Parse(Console.ReadLine());
            int bought_ram = int.Parse(Console.ReadLine());
            // Math
            int price_cards = video_cards * bought_video_cards;
            double price_cpus = price_cards * 0.35 * bought_cpus;
            double price_ram = price_cards * 0.10 * bought_ram;
            // 2ND MATH
            double TotalPrice = price_cards + price_cpus + price_ram; 

            if (bought_video_cards > bought_cpus)
            {
                TotalPrice = TotalPrice * 0.85;
            }

            double budgetDifference = PeterBudget - TotalPrice;


            if (budgetDifference >= 0)
            {
                Console.WriteLine($"You have {budgetDifference:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budgetDifference):f2} leva more!");
            }
        }
    }
}
