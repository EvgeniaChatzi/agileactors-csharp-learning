using System;

namespace Lesson3Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            const string symbol = "*";
            const int counter = 10;

            for (int k = counter; k > 0; k--)
            {
                for(int j = 0; j < k; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }


            for (int r = 0; r < counter; r++)
            {
                for(int c = 0; c <= r; c++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }



        }
    }
}
