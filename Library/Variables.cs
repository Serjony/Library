using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Variables
    {
        public static int CalculateSolutionForEquation(int a, int b)
        {
            int solution;
            if (a==b)
            {
                throw new ArgumentException("a==b");
            }

            solution = (5 * (a + b) * (a + b)) / (b - a);
            return solution;

        }
        public static void SwapNumAAndNumB(ref int a, ref int b)
        {
            int x = a;
            a = b;
            b = x;
        }
        public static int[] GetSolutionForADivideBAndRemOfDivision(int a, int b)
        {

            if (b==0)
            {
                throw new ArgumentException("b == 0");
            }
            
            return new int[]{
                a /b,
                a%b
            };
        }
        public static double GetLinearEquationSolution(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("a == 0");
            }
            double solution = Math.Round((c - b) / a,3);
                return solution;
        }

        public static (double a, double b) GetEquationOfStraightLine(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2 )
            {
                throw new DivideByZeroException("x1-x2=0");
            }

            double a = Math.Round(((y1 - y2) / (x1 - x2)),3);
            double b = Math.Round(y2 - a * x2,3);
            return (a, b);
        }
    }
}
