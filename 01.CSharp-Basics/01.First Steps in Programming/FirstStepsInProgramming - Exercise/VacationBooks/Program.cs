using System;

namespace VacationBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PagesInBook = int.Parse(Console.ReadLine());
            int PagesPerHour = int.Parse(Console.ReadLine());
            int TotalDays = int.Parse(Console.ReadLine());

            int ReadTimePerBook = PagesInBook / PagesPerHour;
            int TimePerDay = ReadTimePerBook / TotalDays;

            Console.WriteLine(TimePerDay);

        }
    }
}
