using System;

namespace BasketballEquip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT SYSTEM
            int FeePerYear = int.Parse(Console.ReadLine());
            // PRICE LIST
            double Shoes = FeePerYear - (FeePerYear * 40/100);
            double BsktEqip = Shoes - (Shoes * 20 / 100);
            double Ball = (BsktEqip * 1 / 4);
            double Accessories = (Ball * 1 / 5);
            // TOTAL PRICE
            double TotalPrice = FeePerYear + Shoes + BsktEqip + Ball + Accessories;
            // PRINT
            Console.WriteLine(TotalPrice);
        }
    }
}
