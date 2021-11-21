using System;

namespace Lesson2Exercise4
{
    class Program
    {
        static void Main(int firstNum, int secondNum)
        {
            Console.WriteLine($"Input the first number: {firstNum}");
            Console.WriteLine($"Input the second number: {secondNum}");
            Console.WriteLine($"{firstNum} + {secondNum} = { firstNum + secondNum}");
            Console.WriteLine($"{firstNum} - {secondNum} = { firstNum - secondNum}");
            Console.WriteLine($"{firstNum} * {secondNum} = { firstNum * secondNum}");
            Console.WriteLine($"{firstNum} / {secondNum} = { firstNum / secondNum}");
            Console.WriteLine($"{firstNum} mod {secondNum} = { firstNum % secondNum}");
            //if enter doubles then at the devision you get a double 6,...
        }
    }
}
