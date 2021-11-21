using System;

namespace Lesson3Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int yaer;
            Console.WriteLine("Input a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0)
            {
                Console.WriteLine("The year is leap");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("The year is not leap");
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine("The year is leap");
            }
            else
            {
                Console.WriteLine("The year is not leap");
            }
        }
    }
}
