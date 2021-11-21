using System;

namespace Lesson3Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance;
            float hours, minutes, seconds;
            float timeInSec;
            float metersPerSecond, kilometersPerHour, milesPerHour;

            Console.Write("Please input distance in metres: ");
            distance = Convert.ToSingle(Console.ReadLine());

            Console.Write("Please input time in hours: ");
            hours = Convert.ToSingle(Console.ReadLine());

            Console.Write("Please input time in minutes: ");
            minutes = Convert.ToSingle(Console.ReadLine());

            Console.Write("Please input time in seconds: ");
            seconds = Convert.ToSingle(Console.ReadLine());

            timeInSec = (hours * 3600) + (minutes * 60) + seconds;
            metersPerSecond = distance / timeInSec;
            kilometersPerHour = (distance / 1000) / (timeInSec / 3600);
            milesPerHour = kilometersPerHour / 1.609f;

            Console.WriteLine($"Your speed in meters per sec is {metersPerSecond}");
            Console.WriteLine($"Your speed in kilometers per hour is {kilometersPerHour}");
            Console.WriteLine($"Your speed in miles per hour is {milesPerHour}");
        }
    }
}
