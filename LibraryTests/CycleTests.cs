using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Tests
{
    class CycleTests
    {
        [TestCase(5, 5, 3125)]
        [TestCase(-3, 3, -27)]
        [TestCase(-10, 2, 100)]
        [TestCase(13, 7, 62748517)]
        public void GetAtoPowB_WhenTestPassed_ReturnAInPowB (int a, int b, int expected)
        {
            int actual = Cycle.GetAtoPowB(a, b);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(300, new int[] {300, 600, 900})]
        [TestCase(1000, new int[] { 1000 })]
        [TestCase(500, new int[] { 500, 1000 })]
        public void GetNumbersFrom1To1000ThatDividedOnNumA_WhenTestPassed_ReturnAllNums (int a, int[] expected)
        {
            int[] actual = Cycle.GetNumbersFrom1To1000DividedA(a);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(0)]
        [TestCase(1001)]
        // [TestCase(-500)]

        public void GetNumbersFrom1To1000ThatDividedOnNumA_WhenTestPassed_ReturnArgumentExpection(int numA)
        {
            Assert.Throws<ArgumentException>(()=>
            {
                int[] actual = Cycle.GetNumbersFrom1To1000DividedA(numA);
            });
        }

        [TestCase(12, 3)]
        [TestCase(27, 5)]
        [TestCase(150, 12)]
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        public void FindAmountOfNumbersWhoseSquareLessThanNumA_WhenTestPassed_ReturnAmountOfNumbers(int a, int expected)
        {
            int actual = Cycle.FindAmountOfNumbersWhoseSquareLessA(a);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(10, 5)]
        [TestCase(77, 11)]
        [TestCase(123, 41)]
        [TestCase(124, 62)]
        [TestCase(1, 0)]
        [TestCase(0, 0)]
        public void FindGreatestDivisorForNumA_WhenTestPassed_ReturnGreatestDivisorForNumA(int a, int expected)
        {
            int actual = Cycle.FindGreatestDivisorForA(a);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, 7, 0)]
        [TestCase(5, 9, 7)]
        [TestCase(3, 300, 6321)]
        [TestCase(46, 58, 105)]
        [TestCase(99, 109, 105)]
        [TestCase(-141, 1, -1470)]
        [TestCase(-228, -37, -3591)]
        public void FindSumOfAllNumsThatDivideBy7_WhenTestPassed_ReturnSumOfAllNums(int a, int b, int expected)
        {
            int actual = Cycle.FindSumOfAllNumsThatDivideBy7(a, b);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(50, 50)]
        [TestCase(0, 0)]
        public void FindSumOfAllNumsThatDivideBy7_WhenTestPassed_ReturnArgumentException(int numA, int numB)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int actual = Cycle.FindSumOfAllNumsThatDivideBy7(numA, numB);
            });
        }

        [TestCase(7, 21)]
        [TestCase(1, 1)]
        [TestCase(13, 377)]
        [TestCase(-3, 1)]
        [TestCase(4, 5)]
        [TestCase(33, 5702887)]
        public void GetNumFibonachi_WhenTestPassed_ReturnNumFibonachi(int a, int expected)
        {
            int actual = Cycle.GetNumFibonachi(a);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(5, 18, 1)]
        [TestCase(58, 6, 2)]
        [TestCase(9, 9, 9)]
        [TestCase(789, 123, 3)]
        [TestCase(785, 700, 5)]

        public void GetEuclideanAlgorithmForNumsAB_WhenTestPassed_ReturnEuclideanAlgorithm(int a, int b, int expected)
        {
            int actual = Cycle.GetEuclideanAlgorithm(a, b);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(8, 2)]
        [TestCase(729, 9)]
        [TestCase(125, 5)]
        public void GetHalfDivisionMethodForNumA_WhenTestPassed_ReturnReceivedNumA(int num, int expected)
        {
            int actual = Cycle.GetHalfDivisionMethod (num);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(322, 1)]
        [TestCase(1, 1)]
        [TestCase(4, 0)]
        [TestCase(123456, 3)]
        [TestCase(-987654321, 5)]
        [TestCase(0, 0)]
        public void GetNumberOfOddInNumA_WhenTestPassed_ReturnNumberOfOdd(int num, int expected)
        {
            int actual = Cycle.FindNumberOfOdd(num);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(123, 321)]
        [TestCase(45678, 87654)]
        [TestCase(1, 1)]
        public void GetMirrorMumber_WhenTestPassed_ReturnMirrorMumber(int num, int expected)
        {
            int actual = Cycle.GetMirrorMumber (num);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(6, new int[] { 2, 4 })]
        [TestCase(6, new int[] { 2, 4 })]
        [TestCase(6, new int[] { 2, 4 })]
        public void FindNumbersAmountOfEvenGreaterThanOdd_WhenTestPassed_ReturnAmountOfEven(int num, int[] expected)
        {
            int[] actual = Cycle.FindNumbersAmountOfEvenGreaterThanOdd(num);

            Assert.AreEqual(expected, actual);

        }

        [TestCase("123", "321", "Yes")]
        [TestCase("123", "456", "No")]
        public void FindIdenticalNumbers_WhenTestPassed_ReturnYesOrNo(string num, string num2, string expected)
        {
            string actual = Cycle.FindIdenticalNumbers (num, num2);

            Assert.AreEqual(expected, actual);

        }
    }
}
