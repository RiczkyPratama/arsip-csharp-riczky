// See https://aka.ms/new-console-template for more information

using System;

namespace ContinueNested
{
    class Program
    {
        static void Main(string[] args)
        {

            //outer loop
            for(int i = 1; i<= 3; i++)
            {

                //inner loop
                for(int j=1; j<=3; j++)
                {
                    if (j==2)
                    {
                        continue;
                    }

                    Console.WriteLine("i = "+ i + " j = " + j);
                }
            }
        }
    }
}
