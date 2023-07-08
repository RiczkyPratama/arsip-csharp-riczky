// See https://aka.ms/new-console-template for more information

using System;

namespace Loop
{
    class WhileLoop
    {
        public static void Main(string[] args)
        {
            int i=1;
            while(i<=5)
            {
                Console.WriteLine("C# For Loop: Iterations {0}", i);
                i++;
            }
        }
    }
}
