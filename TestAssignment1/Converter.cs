using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment1
{
    internal class Converter
    {
        public double FahrenheitToCelsius(double fahrenheitValue)
        {
            double celsius = (fahrenheitValue - 32) * 5 / 9;

            return celsius;
        }

        public double CelsiusToFahrenheit(double celsiusValue)
        {
            double fahrenheit = ((celsiusValue * 9) / 5) + 32;

            return fahrenheit;
        }

        public string ArabicToRoman(int arabicNumeral)
        {
            string romanResult = "";

            Dictionary<string, int> RomanMap = new Dictionary<string, int>()
            {
                  {
                "I",
                1
            }, {
                "IV",
                4
            }, {
                "V",
                5
            }, {
                "IX",
                9
            }, {
                "X",
                10
            }, {
                "XL",
                40
            }, {
                "L",
                50
            }, {
                "XC",
                90
            }, {
                "C",
                100
            }, {
                "CD",
                400
            }, {
                "D",
                500
            }, {
                "CM",
                900
            }, {
                "M",
                1000
            }
        };

            foreach (var item in RomanMap.Reverse())
            {
                if (arabicNumeral <= 0) break;
                while (arabicNumeral >= item.Value)
                {
                    romanResult += item.Key;
                    arabicNumeral -= item.Value;
                }
            }

            return romanResult;
        }
    }
}
