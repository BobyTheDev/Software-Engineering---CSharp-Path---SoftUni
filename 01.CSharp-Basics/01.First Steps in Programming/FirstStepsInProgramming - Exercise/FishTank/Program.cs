using System;

namespace FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // INPUT
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            // MATH FORMULAS
            int AquariumVolume = lenght * width * height;
            double VolumeInL = (double)AquariumVolume / 1000;
            double NeededL = VolumeInL * (1 - percentage / 100);
            // PRINT
            Console.WriteLine(NeededL);
            // WHY THIS WORKS HUHH???? NO FUCKING IDEA.
        }
    }
}
