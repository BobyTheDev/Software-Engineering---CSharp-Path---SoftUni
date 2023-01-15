using System;

namespace WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT SYSTME
            double RecordInSec = double.Parse(Console.ReadLine());
            double DistanceInM = double.Parse(Console.ReadLine());
            double TimeInSec = double.Parse(Console.ReadLine());
            // MATH
            double timeToSwimFullDistance = DistanceInM * TimeInSec;
            timeToSwimFullDistance = timeToSwimFullDistance + (Math.Floor((DistanceInM / 15)) * 12.5);
            double worldRecordDifference = timeToSwimFullDistance - RecordInSec;
            // PRINT
            if (worldRecordDifference >= 0) 
            {
                Console.WriteLine($"No, he failed! He was {worldRecordDifference:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeToSwimFullDistance:f2} seconds.");
            }


        }
    }
}
