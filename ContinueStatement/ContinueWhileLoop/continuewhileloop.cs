// See https://aka.ms/new-console-template for more information

using System;

namespace ContinueWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<5)
            {
                i++;

                if(i==3)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
