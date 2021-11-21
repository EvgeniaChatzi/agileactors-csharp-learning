using System;

namespace Lesson2Exercise6
{
    class Program
    {
        static void Main(int num1, int num2)
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(num1, num2);
            Console.WriteLine(randomNum);
        }
    }
}
