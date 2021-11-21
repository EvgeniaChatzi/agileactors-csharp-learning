using System;

namespace Lesson3Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int loginAttempts = 0;
                string correctUsername = "Evgenia";
                string correctPassword = "Pass123";

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string password = Console.ReadLine();

                    if (username != correctUsername || password != correctPassword)
                        loginAttempts++;
                    else
                        break;
                }

                if (loginAttempts > 5)
                    Console.WriteLine("You failed to login!");
                else
                    Console.WriteLine("Login successful!");
            }
        }
    }
}
