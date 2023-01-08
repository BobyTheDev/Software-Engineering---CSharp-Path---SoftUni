using System;

namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PRICE LIST
            double ChickenMenu = 10.35;
            double FishMenu = 12.40;
            double VeganMenu = 8.15;
            double DeliveryFee = 2.5;
            // INPUT SYSTEM:
            int SumChickenMenu = int.Parse(Console.ReadLine());
            int SumFishMenu = int.Parse(Console.ReadLine());
            int SumVeganMenu = int.Parse(Console.ReadLine());
            // MATHS
            double TotalPriceChicken = SumChickenMenu * ChickenMenu;
            double TotalPriceFish = SumFishMenu * FishMenu;
            double TotalPriceVegan = SumVeganMenu * VeganMenu;
            double TotalPrice = TotalPriceChicken + TotalPriceFish + TotalPriceVegan;
            double dessert = TotalPrice * 0.2;
            double TotalPriceForEverything = TotalPrice + dessert + DeliveryFee;
            Console.WriteLine(TotalPriceForEverything);
            // IDK HOW THIS SHIT WORKS BUT IT WORKS SO I WILL LEAVE IT LIKE THAT
        }
    }
}
