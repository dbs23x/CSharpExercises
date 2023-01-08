using System.Reflection.Metadata;

namespace CSharpExercises.Basics
{
    //Celsius to Fahrenheit
    //Given a temperature in Celsius degrees, write a method that converts it to Fahrenheit degrees.Remember that temperature below -271.15°C (absolute zero) does not exist!
    //Expected input and output
    //CtoF(0) → "T = 32F"
    //CtoF(100) → "T = 212F"
    //CtoF(-300) → "Temperature below absolute zero!"

    public class _02_CelsiusToFahrenheit
    {
        public static string CtoF(double celsius)
        {
            double fahrenheit;

            if (celsius < -273.15)
            {
                return "Temperature below absolute zero!";
            }

            fahrenheit = celsius * 1.8 + 32;

            return $"T = {fahrenheit}F";
        }

        public static void Main()
        {
            Console.WriteLine(CtoF(0));     // T = 32F
            Console.WriteLine(CtoF(-300));  // Temperature below absolute zero!
            Console.WriteLine(CtoF(28.5));  // T = 83.3F
        }
    }
}
