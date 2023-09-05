using System;

namespace Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Четем от конзолата брой на незадоволителни оценки, които може да получи
            int badGrades = int.Parse(Console.ReadLine());

            // 2. Създаваме променливи за:
            //=> сумата на всички оценки
            int sumOfGrades = 0;
            //=>броя на всички оценки
            int totalGrades = 0;
            //=>брояч на незадоволителни оценки
            int badCounter = 0;
            //=>име на последна задача
            string lastJob = string.Empty;

            string input = Console.ReadLine();
            int grade; // САМО ЗА WHILE ЦИКЪЛА
            //3. Създаваме while, който се изпълянява, докато не получи съобщение "Enough"
            while (input != "Enough")
            {
                //=> ако input-ът е различен от "Enough" => той е име на ПОСЛЕДНАТА задача до момента
                lastJob = input;
                //=> четем оценка за конкретна задача
                grade = int.Parse(Console.ReadLine());
                // => добавяме оценката към сумата на всички оценки до момента
                sumOfGrades += grade;
                // => увеличаваме брояча на всички оценки с 1
                totalGrades++;
                // => проверяваме тази оценка задоволителна ли е?
                if (grade <= 4)
                {
                    // ==> ако не е: увеличаваме брояча на незадоволителни оценки, за да прекъсне
                    badCounter++;

                    //=> проверяваме дали е достигнал броя на незадоволителните оценки, за да прекъсне
                    if (badCounter == badGrades)
                    {
                        //==> ако е: спираме изпълнението на цикъла
                        Console.WriteLine($"You need a break, {badCounter} poor grades.");
                        break;
                    }
                    //====> отпечатваме на конзолата:
                    //====> спираме изпълнението на цикъла
                }

                //=> четем нов вход от конзолата
                input = Console.ReadLine();
            }
            //4. Проверяваме дали последният input == "Enough"
            if (input == "Enough")
            {
                //=> Ако е, отпечатваме: .....
                Console.WriteLine($"Average score: {(double)sumOfGrades/totalGrades:f2}");
                Console.WriteLine($"Number of problems: {totalGrades}");
                Console.WriteLine($"Last problem: {lastJob}");
            }
        }
    }
}
