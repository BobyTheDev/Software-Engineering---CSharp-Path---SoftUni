using System;

namespace DepositCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = int.Parse(Console.ReadLine());
            int depositMonths = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double amountedTax = depositSum * procent / 100;
            double oneMonthTax = amountedTax / 12;

            double finalSum = depositSum + (depositMonths * oneMonthTax);

            Console.WriteLine(finalSum);
        }
    }
}
