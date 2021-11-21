using System;

namespace Lesson2Exercise5
{
    class Program
    {
        static void Main(float tempCelsius)
        {
            var tempKelvin = tempCelsius + 273;
            var tempFahrenheit = (tempCelsius * 18) / 10 + 32;
            Console.WriteLine($"The temperature in Kelvin is {tempKelvin} and in Fahrenheit is {tempFahrenheit}");
        }
    }
}
