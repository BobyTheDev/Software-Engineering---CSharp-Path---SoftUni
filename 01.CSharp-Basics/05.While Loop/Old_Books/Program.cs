﻿using System;

namespace Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int count = 0;
            string input = Console.ReadLine();

            while (input != "No More Books")
            {
                if (input == favoriteBook)
                {
                    break;
                }
                count++;

                input = Console.ReadLine();
            }
            if (input == favoriteBook)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }

        }
    }
}
