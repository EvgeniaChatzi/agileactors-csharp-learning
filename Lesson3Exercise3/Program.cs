using System;

namespace Lesson3Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            float myNumber;

            Console.WriteLine("Enter a number: ");
            myNumber = Convert.ToSingle(Console.ReadLine());

            if (myNumber % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is not even");
            }
        }
    }
}
