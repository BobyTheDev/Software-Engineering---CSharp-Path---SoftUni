using System;

namespace ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int NumberProjectsToBeMade = int.Parse(Console.ReadLine());
            int projectTime = NumberProjectsToBeMade * 3;

            if (NumberProjectsToBeMade >= 100)
            {
                Console.WriteLine("Can not exceed 100!");
            }
            else
            {
                Console.WriteLine($"The architect {architectName} will need {projectTime} hours to complete {NumberProjectsToBeMade} project/s.");
            }
        }
    }
}
