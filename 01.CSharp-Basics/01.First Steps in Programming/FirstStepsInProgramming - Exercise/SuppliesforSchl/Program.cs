using System;

namespace SuppliesforSchl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double packetPens = 5.80;
            double packetMarkers = 7.20;
            double Preparat = 1.20;
            // PRICE LIST
            int NumberPacketPens = int.Parse(Console.ReadLine());
            int NumberPacketMarkers = int.Parse(Console.ReadLine());
            int LitersForCleaningBoard = int.Parse(Console.ReadLine());
            int PercantageDiscount = int.Parse(Console.ReadLine());
            // READ LINES
            double PricePens = NumberPacketPens * packetPens;
            double PriceMarkers = NumberPacketMarkers * packetMarkers;
            double PricePreparat = LitersForCleaningBoard * Preparat;
            double SumOfAll = PricePens + PriceMarkers + PricePreparat;
            double PriceAfterDiscount = SumOfAll - (SumOfAll * PercantageDiscount / 100);

            Console.WriteLine(PriceAfterDiscount);
        }
    }
}
