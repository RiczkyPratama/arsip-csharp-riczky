// See https://aka.ms/new-console-template for more information

using System;

namespace WhileBreak 
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<=5)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    // terminates the loop
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
