using System;

namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int piecesCount = lenght * width;
            string pieces;
            while ( (piecesCount > -1) && ( (pieces = Console.ReadLine() ) != "STOP") )
            {
                piecesCount = int.Parse(pieces);
            }
            if (piecesCount > -1 )
            {
                Console.WriteLine($"{piecesCount} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(piecesCount)} pieces more.");
            }
        }
    }
}
