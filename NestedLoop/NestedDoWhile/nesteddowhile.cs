// See https://aka.ms/new-console-template for more information

using System;

namespace Loop
{
    class NestedWhileLoop
    {
        public static void Main(string[] args)
        {
            int i=0;
            do
            {
                int j=0;
                do
                {
                    Console.Write("({0},{1})", i, j);
                    j++;
                }
                while (j<2);
                i++;
                Console.WriteLine();
            }
            while(i<2);
        }
    }
}
