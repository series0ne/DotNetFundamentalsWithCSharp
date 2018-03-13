namespace StructureSample
{
    using System;

    public struct Temperature : IEquatable<Temperature>
    {
        private readonly double temperatureInKelvin;

        public Temperature(double temperatureInKelvin)
        {
            this.temperatureInKelvin = temperatureInKelvin;
        }

        public double Celsius => Math.Round(temperatureInKelvin - 273.15, 3);
        public double Fahrenheit => Math.Round((temperatureInKelvin * 1.80) - 459.67, 3);
        public double Kelvin => Math.Round(temperatureInKelvin, 3);

        public static bool operator ==(Temperature a, Temperature b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Temperature a, Temperature b)
        {
            return !a.Equals(b);
        }

        public static Temperature FromCelsius(double value)
        {
            return new Temperature(value + 273.15);
        }

        public static Temperature FromFahrenheit(double value)
        {
            return new Temperature((value + 459.67) / 1.80);
        }

        public static Temperature FromKelvin(double value)
        {
            return new Temperature(value);
        }

        public bool Equals(Temperature other)
        {
            return temperatureInKelvin == other.temperatureInKelvin;
        }

        public override bool Equals(object obj)
        {
            return !(obj is null)
                && obj is Temperature
                && Equals((Temperature)obj);
        }

        public override int GetHashCode()
        {
            return temperatureInKelvin.GetHashCode();
        }

        public override string ToString()
        {
            return $"{temperatureInKelvin}°K";
        }
    }
}
