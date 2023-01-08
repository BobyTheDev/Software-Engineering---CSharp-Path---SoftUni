using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PRICE LIST PER SQ. M
            double PriceSafetyNylon = 1.50;
            double PricePaint = 14.50;
            int PricePaintThinner = 5;
            // INPUT SYSTEM
            int NeededNylon = int.Parse(Console.ReadLine());
            int NeededPaint = int.Parse(Console.ReadLine());
            int NeededPaintThinner = int.Parse(Console.ReadLine());
            int TimeNeededForMasters = int.Parse(Console.ReadLine());
            // MATHS
            double TotalPriceForNylon = (NeededNylon + 2) * PriceSafetyNylon;
            double TotalPriceForPaint = (NeededPaint * 1.1) * PricePaint;
            double TotalPriceForPaintThinner = NeededPaintThinner * PricePaintThinner;
            double PricePouch = 0.40;
            double TotalSumForMaterials = TotalPriceForNylon + TotalPriceForPaint + TotalPriceForPaintThinner + PricePouch;
            // DEBUGGER Console.WriteLine(TotalSumForMaterials);
            double PriceForMasters = (TotalSumForMaterials * 30 / 100) * TimeNeededForMasters;
            double FinalSum = TotalSumForMaterials + PriceForMasters;

            Console.WriteLine(FinalSum);
        }
    }
}
