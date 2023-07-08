// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'e';

            switch (ch)
            {
                case 'a':
                Console.WriteLine("Vowel");
                break;

                case 'e':
                Console.WriteLine("Vowel");
                break;
                
                case 'i':
                Console.WriteLine("Vowel");
                break;

                case 'o':
                Console.WriteLine("Vowel");
                break;

                case 'u':
                Console.WriteLine("Vowel");
                break;

                default:
                Console.WriteLine("Not a Vowel");
                break;
            }
        }
    }
}
