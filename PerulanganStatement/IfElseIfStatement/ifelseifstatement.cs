// See https://aka.ms/new-console-template for more information

using System;

namespace Conditional
{
    class IfElseIfStatement
    {
        public static void Main(string[] args)
        {
            int number = 23;

            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }
            else if (number > 5)
            {
                Console.WriteLine("{0} is greater than 5", number);
            }
            else
            {
                Console.WriteLine("{0} is equal to 5", number);
            }
        }
    }
}
