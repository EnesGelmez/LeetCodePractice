using System;
using System.Collections.Generic;

namespace RomantoInteger_Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt());
        }
        public static int RomanToInt()
        {
            var cities = new Dictionary<string, int>() {
                {"I" ,1} ,
                {"V" ,5} ,
                {"X" ,10} ,
                {"L" ,50} ,
                {"C" ,100} ,
                {"D" ,500} ,
                {"M" ,1000}
            };
            string roman = "MCMXCIV";
            int result = 0;
            foreach (var item in roman)
            {
                result = result + cities[item.ToString()];
            }

            if (roman.Contains("IV") || roman.Contains("IX"))
            {
                result -= 2;
            }
            if (roman.Contains("XL") || roman.Contains("XC"))
            {
                result -= 20;
            }
            if (roman.Contains("CD") || roman.Contains("CM"))
            {
                result -= 200;
            }
            return result;
        }
    }
}
