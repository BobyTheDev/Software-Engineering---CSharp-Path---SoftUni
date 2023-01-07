using System;

namespace YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = int.Parse(Console.ReadLine());

            if (area > 10000)
            {
                Console.WriteLine("The total area can't be more than 10 000 sq. m.!");
            }
            else
            {
                double price = area * 7.61;
                double discount = price * 0.18;
                double priceAfterDiscount = price - (discount);

                Console.WriteLine($"The final price is {priceAfterDiscount} lv.");
                Console.WriteLine($"The discount is: {discount}");
            }
        }
    }
}
