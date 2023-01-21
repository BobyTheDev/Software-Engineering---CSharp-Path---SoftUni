using System;

namespace SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(0.50 * quantity);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(0.40 * quantity);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(0.45 * quantity);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else if (product == "water")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(0.80 * quantity);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(0.70 * quantity);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(0.70 * quantity);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else if (product == "beer")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(1.20 * quantity);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(1.15 * quantity);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(1.10 * quantity);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else if (product == "sweets")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(1.45 * quantity);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(1.30 * quantity);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(1.35 * quantity);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else if (product == "peanuts")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(1.60 * quantity);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(1.50 * quantity);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(1.55 * quantity);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
