using System;

namespace Time_15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // ЧЕТЕ ЧАС И МИНУТИ / 24:00
                // ИЗЧИСЛЯВА КОЛКО ЩЕ БЪДЕ ЧАСЪТ СЛЕД 15 МИН
                // ЧАС:МИНУТИ
                // ЧАС МЕЖДУ 0 ДО 23 И МИНУТИ 0 ДО 59
                // ВОДЕЩА НУЛА КОГАТО Е НЕОБХОДИМО
                // 1 STEP
                int HoursOfTheDay = int.Parse(Console.ReadLine());
                int MinutesOfTheDay = int.Parse(Console.ReadLine());
                // 2 STEP
                if (MinutesOfTheDay + 15 > 59)
                {
                    HoursOfTheDay += 1;
                    MinutesOfTheDay = 15 - (60 - MinutesOfTheDay);
                }
                else if (MinutesOfTheDay + 15 <= 59) MinutesOfTheDay += 15;
                if (HoursOfTheDay == 24) HoursOfTheDay = 0;

                if (MinutesOfTheDay <= 9)
                {
                    Console.WriteLine($"{HoursOfTheDay}:0{MinutesOfTheDay}");
                }
                else
                {
                    Console.WriteLine($"{HoursOfTheDay}:{MinutesOfTheDay}");
                }

                // НИЩО НЕ РАЗБИРАМ ЛОЛ
            }
        }
    }
}
