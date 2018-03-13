namespace StructureSample
{
    using System;

    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            Temperature a = Temperature.FromCelsius(1.23);
            WriteTemperatureInformation(a);

            Temperature b = Temperature.FromFahrenheit(123.45);
            WriteTemperatureInformation(b);

            Temperature c = Temperature.FromKelvin(667.092);
            WriteTemperatureInformation(c);

            Console.Read();
        }

        private static void WriteTemperatureInformation(Temperature temperature)
        {
            Console.WriteLine($"The temperature in Celsius is {temperature.Celsius}");
            Console.WriteLine($"The temperature in Fahrenheit is {temperature.Fahrenheit}");
            Console.WriteLine($"The temperature in Kelvin is {temperature.Kelvin}");
            Console.WriteLine();
        }
    }
}
