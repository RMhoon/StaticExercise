using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32)/1.8;
        }

        public static double CelsiusToFahrenheit(double celsius)
        { 
            return (celsius *1.8) + 32; 
        }
    }
}
