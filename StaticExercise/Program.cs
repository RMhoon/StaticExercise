using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Celsius to convert");
            var cel = double.Parse(Console.ReadLine());
            Console.WriteLine($"C {cel} is F:{TempConverter.CelsiusToFahrenheit(cel):#,###.#}");

            Console.WriteLine("Enter Fahrenheit to convert");
            var fahren = double.Parse(Console.ReadLine());
            Console.WriteLine($"F {fahren}  is C:{TempConverter.FahrenheitToCelsius(fahren):#,###.#}");
        }
    }
}
