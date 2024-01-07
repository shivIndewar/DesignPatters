using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius = 37; double fahernheit = 98.6;

            Console.WriteLine("Value of {0} celcius to fahrenheit is {1}",
               celcius, convertor.ToFahrenheit(celcius));

            Console.WriteLine("Value of {0} fahrenheit to celcius is {1}",
               fahernheit, convertor.ToCelcius(fahernheit));

            Console.ReadKey();
        }
    }
}
