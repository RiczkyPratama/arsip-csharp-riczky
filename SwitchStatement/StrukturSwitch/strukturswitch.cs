// See https://aka.ms/new-console-template for more information

using System;

namespace Conditional
{
    class SwitchCase
    {
        public static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter an alphabet");
            ch = Convert.ToChar(Console.ReadLine());

            switch(Char.ToLower(ch))
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
                Console.WriteLine("Not a vowel");
                break;
            }
        }
    }
}