using System;

namespace InchToCm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cm = double.Parse(Console.ReadLine());
            double inch = 2.54;

            double result = cm * inch;
            Console.WriteLine(result);
        }
    }
}
