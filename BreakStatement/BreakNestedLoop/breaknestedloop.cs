// See https://aka.ms/new-console-template for more information

using System;

namespace NestedBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 3; i++) //outer loop
            {
                //inner loop
                for (int j = 1; j <= 3; j++)
                {
                    if (i == 2)
                    {
                        break;
                    }
                    Console.WriteLine("i = " + i + " j = " + j);
                }
                
            }
            Console.ReadLine();
        }
    }
}
