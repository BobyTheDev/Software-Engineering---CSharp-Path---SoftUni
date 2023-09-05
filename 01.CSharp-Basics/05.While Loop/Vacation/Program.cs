using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Прочитаме от конзолата
            //=> Пари нужни за екскурзията - тип double
            double costOfTrip = double.Parse(Console.ReadLine());
            //=> Налични пари - тип double
            double currentMoney = double.Parse(Console.ReadLine());
            // 2. Създаваме променливи
            //=> Брояч на дните - тип int
            int daysCounter = 0;
            //=> Брояч на харчене - тип int
            int spendingDays = 0;
            // 3. Създаваме while цикъл, който продължава, докато парите на Джеси са по-малко от парите,
            //    които са й нужни за екскурзията и броячът за последователните дни е по-малък от 5.
            while (currentMoney < costOfTrip && spendingDays < 5)
            {
                daysCounter++;
                //=> Да се чете от конзолата два реда
                //==> Първият ред текст (spend или save)
                string action = Console.ReadLine();
                //==> Да се чете на вторият ред парите които Джеси е спетила или похарчила
                double dailyMoney = double.Parse(Console.ReadLine());
                //=> Увеличаваме брояча за дни с 1
                if (action == "save")
                {
                    currentMoney += dailyMoney;
                    spendingDays = 0;
                }
                else if (action == "spend")
                {
                    currentMoney -= dailyMoney;
                    if (currentMoney < 0) currentMoney = 0;
                    spendingDays++;
                    if (spendingDays > 4) break;
                }
            }

            // 4. Проверка дали Джеси е харчила пари в пет последователни дни
            if (spendingDays > 4) Console.WriteLine($"You can't save the money.\n{daysCounter}");
            else Console.WriteLine($"You saved the money for {daysCounter} days.");
        }
    }
}
