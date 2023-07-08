// See https://aka.ms/new-console-template for more information

using System;

namespace Loop
{
    class DoWhileLoop
    {
        public static void Main(string[] args)
        {
            int i = 1, n = 5, product;

            do
            {
                product = n*i;
                Console.WriteLine("{0} * {1} = {2}", n, i, product);
                i++;
            }
            while (i <= 10);
        }
    }
}
