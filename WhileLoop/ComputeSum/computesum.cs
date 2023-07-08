// See https://aka.ms/new-console-template for more information

using System;

namespace Loop
{
    class WhileLoop
    {
        public static void Main(string[] args)
        {
            int i=1, sum=0;
            
            while (i<=5)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("Sum = {0}", sum);
        }
    }
}
