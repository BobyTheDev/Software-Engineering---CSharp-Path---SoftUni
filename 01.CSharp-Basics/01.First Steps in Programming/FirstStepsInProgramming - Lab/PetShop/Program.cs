using System;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFoodPackages = int.Parse(Console.ReadLine());
            int catFoodPackages = int.Parse(Console.ReadLine());

            double dogFoodPrice = 2.50;
            int catFoodPrice = 4;

            double dogExpenses = dogFoodPackages * dogFoodPrice;
            int catExpenses = catFoodPackages * catFoodPrice;

            double sum = dogExpenses + catExpenses;

            Console.WriteLine($"{sum} lv.");


        }
    }
}
