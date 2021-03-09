using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Variables
    {
        public static int CalculateSolutionForEquation(int a, int b)
        {
            int solution;
            if (a==b)
            {
                throw new Exception("a==b");
            }

            solution = (5 * (a + b) * (a + b)) / (b - a);
            return solution;

        }
        public static void Swap(ref int a, ref int b)
        {
            int x = a;
            a = b;
            b = x;
        }
        public static int[] Division(int a, int b)
        {

            if (b==0)
            {
                throw new Exception("b == 0");
            }
            
            return new int[]{
                a /b,
                a%b
            };
        }
        public static int GetLinearEquationSolution(int a, int b, int c)
        {
            int solution = (c - b) / a;
                return solution;
        }

        public static (double a, double b) GetEquationOfStraightLine(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2 && ((x1 - x2) == 0))
            {
                throw new DivideByZeroException("x1-x2=0");
            }

            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;
            return (a, b);
        }
    }
}
