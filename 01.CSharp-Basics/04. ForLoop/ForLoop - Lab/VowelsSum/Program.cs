using System;

namespace VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Vowels = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < Vowels.Length; i++)
            {
                char Vowel = Vowels[i];

            switch (Vowel)
                {
                    case 'a': sum++; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                    default: break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
