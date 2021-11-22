using System;

namespace Lesson3Exercise6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter one of the following operations--> + , -, *, / : ");
            string operation = Console.ReadLine();

            if(operation == "+")
            {
                int result = firstNumber + secondNumber;
                Console.WriteLine($"The result is: {result}" );
            } else if (operation == "-")
            {
                int result = firstNumber - secondNumber;
                Console.WriteLine($"The result is: {result}");
            }else if(operation == "*")
            {
                int result = firstNumber * secondNumber;
                Console.WriteLine($"The result is: {result}");
            }else if(operation == "/")
            {
                if(secondNumber == 0)
                {
                    Console.WriteLine("We cannot devide by 0! Enter another number");
                    float anotherNumber = Convert.ToInt32(Console.ReadLine());
                    float result = firstNumber / anotherNumber;
                    Console.WriteLine($"The result is: {result}");
                }
                else
                {
                    float result = firstNumber / secondNumber;
                    Console.WriteLine($"The result is: {result}");
                }
                
            }
        }
    }
}
