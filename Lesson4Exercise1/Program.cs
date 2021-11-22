using System;

namespace Lesson4Exercise1
{
    class Program
    {

        static void Main(string[] args)
        {
            var numbers = new Numbers();
            numbers.Actions(3);
            numbers.Actions(-7);
            numbers.Actions(0);
        }
    }

    public class Numbers
    {

        public void Actions(int number)
        {
            if(number > 0 || number == 0 )
            {
                double sqrt = Math.Sqrt(number);
                Console.WriteLine($"The squere root of the number is {sqrt}");
            }
            else if (number < 0)
            {
                double power = Math.Pow(number, 2);
                Console.WriteLine($"The number in the power of two is {power}");
            }
        }
    }
}
