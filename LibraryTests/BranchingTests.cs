using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Tests
{
    class BranchingTests
    {
        [TestCase(7, 4, 11)]
        [TestCase(5, 13, -8)]
        [TestCase(3, 3, 9)]
        public void GetIfCountForNumsAB_WhenTestPassed_ReturnCountResult(int a, int b, int expected)
        {
            int actual = Branching.GetIfCountAB(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 12, 1)]
        [TestCase(-3, 53, 2)]
        [TestCase(-15, -64, 3)]
        [TestCase(41, -9, 4)]

        public void GetQuarterForPoint_WhenTestPassed_ReturnQuarter(double x, double y, double expected)
        {
            double actual = Branching.GetQuarterForPoint(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(55, 18, 4, 4, 18, 55)]
        [TestCase(698, 1056, -7, -7, 698, 1056)]
        [TestCase(14, 69, 5.5, 5.5, 14, 69)]

        public void GetIncreaseForABC_WhenTestPassed_ReturnSortedOrder(double actualA, double actualB, double actualC, double expectedA, double expectedB, double expectedC)
        {
            Branching.GetIncreaseForABC(ref actualA, ref actualB, ref actualC);

            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
            Assert.AreEqual(expectedC, actualC);
        }

        [TestCase(5, 7, 12, new double[] { })]
        [TestCase(-6, -3, 2, new double[] { -0.879, 0.379 })]
        [TestCase(2, 4, 2, new double[] { -1 })]
        [TestCase(75.3, -42.6, -789, new double[] { 3.532 , -2.966 })]

        public void GetSolutionForQuadraticEquation_WhenTestPassed_ReturnSolution(double num1, double num2, double num3, double[] expected)
        {
            double[] actual = Branching.GetSolutionForQuadraticEquation(num1, num2, num3);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 2, 3)]
        public void GetSolutionForQuadraticEquation_WhenTestPassed_ReturnArgumentExpection(double num1, double num2, double num3)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                double[] actual = Branching.GetSolutionForQuadraticEquation(num1, num2, num3);
            });
        }

        [TestCase(10, "ten")]
        [TestCase(12, "twelve")]
        [TestCase(18, "eighteen")]
        [TestCase(20, "twenty")]
        [TestCase(50, "fifty")]
        [TestCase(67, "sixty seven")]
        [TestCase(89, "eighty nine")]
        public void GetNumberByWords_WhenTestPassed_ReturnNumberByWords(int num, string expected)
        {
            string actual = Branching.GetNumberByWords(num);

            Assert.AreEqual(expected, actual);
        }
    }
}
