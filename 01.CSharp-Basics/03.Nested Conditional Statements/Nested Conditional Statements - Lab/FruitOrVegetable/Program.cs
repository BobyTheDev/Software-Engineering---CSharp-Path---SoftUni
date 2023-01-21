using System;

namespace FruitOrVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruitOrVegetable = Console.ReadLine();
            switch (fruitOrVegetable)
            {
                    // FRUITS
                case "banana": 
                    Console.WriteLine("fruit"); 
                    break; 
                case "apple": 
                    Console.WriteLine("fruit"); 
                    break; 
                case "kiwi": 
                    Console.WriteLine("fruit"); 
                    break; 
                case "cherry": 
                    Console.WriteLine("fruit"); 
                    break;
                case "lemon": 
                    Console.WriteLine("fruit"); 
                    break;
                case "grapes": 
                    Console.WriteLine("fruit"); 
                    break;
                // VEGETABLES
                case "tomato": 
                    Console.WriteLine("vegetable");
                    break;
                case "cucumber":
                    Console.WriteLine("vegetable");
                    break;
                case "pepper":
                    Console.WriteLine("vegetable");
                    break;
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default: 
                    Console.WriteLine("unknown"); 
                    break;
            }
        }
    }
}
