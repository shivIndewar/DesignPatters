using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public static class convertor
    {
        public static double ToFahrenheit(double celcius)
        {

            return (celcius * 9/5) + 32;
        }

        public static double ToCelcius(double fahernheit)
        { 
            return (fahernheit - 32) * 5/9;
        }
    }
}
