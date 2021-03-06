using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Branching
    {
        public static int GetIfCountAB(int a, int b)
        {
            int result;

            if (a > b)
            {
                result = a + b;
            }
            else if (a < b)
            {
                result = a - b;
            }
            else
            {
                result = a * b;
            }
            return result;
        }
        public static double GetQuarterForPoint(double x, double y)
        {
            double result = 0;

            if (x > 0 && y > 0)
            {
                result = 1;
            }
            else if (x < 0 && y > 0)
            {
                result = 2;
            }
            else if (x < 0 && y < 0)
            {
                result = 3;
            }
            else if (x > 0 && y < 0)
            {
                result = 4;
            }

            return result;
        }
        public static void GetIncreaseForABC(ref double a, ref double b, ref double c)
        {
            if (a > b)
            {
                double x = a;
                a = b;
                b = x;
            }
            if (a > c)
            {
                double y = a;
                a = c;
                c = y;
            }
            if (b > c)
            {
                double z = b;
                b = c;
                c = z;
            }
        }
        public static double[] GetSolutionForQuadraticEquation(double num1, double num2, double num3)
        {
            if (num1 == 0)
            {
                throw new ArgumentException("a==0");
            }

            double d = Math.Pow(num2, 2) - (4 * num1 * num3);
            double[] result;

            if (d == 0)
            {
                result = new[] { -num2 / (2 * num1) };
            }
            else if(d > 0)
            {
                result = new[]
                {
                    Math.Round((-num2 + Math.Sqrt(d)) / (2 * num1),3),
                    Math.Round((-num2 - Math.Sqrt(d)) / (2 * num1),3)
                };
            }
            else
            {
                result = new double[] { };
            }

            return result;
        }
        public static string GetNumberByWords(int number)
        {
            string result = String.Empty;
            string[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] elevenToNineteen = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number >= 11 && number <= 19)
            {
                result = elevenToNineteen[number % 10 - 1];
            }
            else if (number % 10 == 0)
            {
                result = tens[number / 10 - 1];
            }
            else
            {
                result = tens[number / 10 - 1] +" "+ units[number % 10];
            }

            return result;
        }
    }
}
