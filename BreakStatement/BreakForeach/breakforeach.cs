// See https://aka.ms/new-console-template for more information

using System;

namespace ForEachBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num={1,2,3,4,5};

            //use of for each loop
            foreach(int number in num)
            {
                //terminates the loop
                if(number==3)
                {
                    break;
                }
                Console.WriteLine(number);
            }
        }
    }
}
