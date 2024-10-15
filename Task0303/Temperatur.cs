using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task0303.Interfaces;

namespace Task0303
{
    internal class Temperatur : ICelsius, IFahrenheit, IKelvin
    {
        double _temperatur;
        public double Kelvin
        {
            get => _temperatur + 273.15;
            set => _temperatur = value - 273.15;
        }
        public double Fahrenheit
        {
            get => CelsiusToFahrenheit(_temperatur);
            set => _temperatur = FahrenheitToCelsius(value);
        }
        public double Celsius
        {
            get => _temperatur;
            set => _temperatur = value;
        }

        static double FahrenheitToCelsius(double f)
        {
            return 5.0 / 9.0 * (f - 32);
        }

        static double CelsiusToFahrenheit(double c) {
            return (c * 9) / 5 + 32;
        }

        public override string ToString()
        {
            return "Gespeicherte Temperatur: " + Celsius + "°C , " +
                +Kelvin + "°K, " +
                +Fahrenheit + "°F";
        }

        string ICelsius.ToString() { return ""; }
            
    }
}
