// See https://aka.ms/new-console-template for more information

using System;

namespace AccessArrayForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3};

            Console.WriteLine("Array Elements: ");

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
