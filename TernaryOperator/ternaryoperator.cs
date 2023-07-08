// See https://aka.ms/new-console-template for more information

using System;

namespace Conditional
{
    class Ternary
    {
        public static void Main(string[] args)
        {
            int number = 2;
            bool isEven;

            isEven = (number % 2 == 0) ? true : false;
            Console.WriteLine(isEven);
        }
    }
}