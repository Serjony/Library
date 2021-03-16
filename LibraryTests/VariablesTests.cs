using NUnit.Framework;
using System;

namespace Library.Tests
{
    public class VariablesTests
    {
        
        [TestCase(3, 4, 245)]
        [TestCase(-458, 36, 1802)]
        [TestCase(-123, -321, -4978)]
        public void CalculateSolutionForEquation_WhenTestPassed_ReturnSolution(int a, int b, int expected)
        {
            
            int actual = Variables.CalculateSolutionForEquation(a, b);
                
            Assert.AreEqual(expected, actual);
 
        }

        [TestCase(7, 7)]
        [TestCase(0, 0)]
        public void CalculateSolutionForEquation_WhenTestPassed_ReturnArgumentException(int num1, int num2)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int actual = Variables.CalculateSolutionForEquation(num1, num2);
            });
        }

        [TestCase (1, 2, 2, 1)]
        [TestCase (25, -4, -4, 25)]
        [TestCase (123, 321, 321, 123)]
        public void SwapNumAAndNumB_WhenTestPassed_ReturnSolution(int actualA, int actualB, int expectedA, int expectedB)
        {

            Variables.SwapNumAAndNumB(ref actualA, ref actualB);

            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);

        }

        [TestCase (50, 15, new int[] { 3, 5 })]
        [TestCase(-7, 120, new int[] { 0, -7 })]
        [TestCase(0, 33, new int[] { 0, 0 })]
        public void GetSolutionForADivideBAndRemOfDivision_WhenTestPassed_ReturnSolutionAndRem(int a, int b, int[] expected)
        {

            int[] actual = Variables.GetSolutionForADivideBAndRemOfDivision(a, b);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(5, 0)]
        [TestCase(22, 0)]
        public void GetSolutionForADivideBAndRemOfDivisionn_WhenTestPassed_ReturnArgumentException(int num1, int num2)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int[] actual = Variables.GetSolutionForADivideBAndRemOfDivision(num1, num2);
            });
        }

        [TestCase(5, 12, 2, -2)]
        [TestCase(1, 1, 1, 0)]
        [TestCase(9, 9, -1, -1.111)]
        [TestCase(3, -3, 0, 1)]
        public void GetLinearEquationSolution_WhenTestPassed_ReturnSolution(double a, double b, double c, double expected)
        {
            double actual = Variables.GetLinearEquationSolution(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 5, 8)]
        [TestCase(0, 21, 14)]
        public void GetLinearEquationSolution_WhenTestPassed_ReturnArgumentException(double num1, double num2, double num3)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                double actual = Variables.GetLinearEquationSolution(num1, num2, num3);
            });
        }

        [TestCase(77, 5, 14, 86, -1.286, 104.004)]
        public void GetEquationOfStraightLine_WhenTestPassed_ReturnEquation(int x1, int y1, int x2, int y2, double expected1, double expected2)
        {
            (double actual1, double actual2) = Variables.GetEquationOfStraightLine(x1, y1, x2, y2);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        //[TestCase(3, 5, 3, 8)]

        //public void GetEquationOfStraightLine__WhenTestPassed_ReturnDivideByZeroException(double x1, double y1, double x2, double y2)
        //{
        //    Assert.Throws<DivideByZeroException>(() =>
        //    {
        //        double actual = Variables.GetLinearEquationSolution( x1,  y1,  x2,  y2);
        //    });
        //}

    }
}