using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Tests
{
    class DoubleArraysTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public static void GetMinElemInArray_WhenArrayPassed_ReturnMinElemtOfArray(int mockNumber, int excpected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);
            int actual = DoubleArrays.FindMinElementInDoubleArray(array);

            Assert.AreEqual(actual, excpected);
        }

        [TestCase(0)]
        [TestCase(null)]
        public static void GetMinElemInArray_WhenArrayPassed_ReturnArgumentException(int mockNumber)
        {
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                int[,] array = DoubleArrayMock.GetMock(mockNumber);
                int actual = DoubleArrays.FindMinElementInDoubleArray(array);
            });
        }

        [TestCase(1, 9)]
        [TestCase(2, 2)]
        public static void GetMaxElemInArray_WhenArrayPassed_ReturnMaxElemtOfArray(int mockNumber, int excpected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);
            int actual = DoubleArrays.FindMaxElementInDoubleArray(array);

            Assert.AreEqual(actual, excpected);
        }

        [TestCase(0)]
        [TestCase(null)]
        public static void GetMaxElemInArray_WhenArrayPassed_ReturnArgumentException(int mockNumber)
        {
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                int[,] array = DoubleArrayMock.GetMock(mockNumber);
                int actual = DoubleArrays.FindMaxElementInDoubleArray(array);
            });
        }

        [TestCase(1, new int[] { 0, 0 })]
        [TestCase(2, new int[] { 0, 0 })]
        public static void GetIndexOfMinElemInArray_WhenArrayPassed_ReturnIndexOfMinElem(int mockNumber, int[] excpected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);
            int[] actual = DoubleArrays.FindIndexOfMinElementInDoubleArray(array);

            Assert.AreEqual(actual, excpected);
        }

        [TestCase(0)]
        [TestCase(null)]
        public static void GetIndexOfMinElemInArray_WhenArrayPassed_ReturnArgumentException(int mockNumber)
        {
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                int[,] array = DoubleArrayMock.GetMock(mockNumber);
                int actual = DoubleArrays.FindMinElementInDoubleArray(array);
            });
        }

        [TestCase(1, new int[] { 2, 2 })]
        [TestCase(2, new int[] { 0, 2 })]
        public static void GetIndexOfMaxElemInArray_WhenArrayPassed_ReturnIndexOfMaxElem(int mockNumber, int[] excpected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);
            int[] actual = DoubleArrays.FindIndexOfMaxElementInDoubleArray(array);

            Assert.AreEqual(actual, excpected);
        }

        [TestCase(0)]
        [TestCase(null)]
        public static void GetIndexOfMaxElemInArray_WhenArrayPassed_ReturnArgumentException(int mockNumber)
        {
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                int[,] array = DoubleArrayMock.GetMock(mockNumber);
                int actual = DoubleArrays.FindMaxElementInDoubleArray(array);
            });
        }

        [TestCase(1, 1)]
        [TestCase(2, 0)]
        [TestCase(5, 1)]
        [TestCase(7, 5)]
        public static void GetNumberOfElemInArrayThatLargerThanAllTheirNeighbors_WhenArrayPassed_ReturnNumberOfElem(int mockNumber, int expected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);
            int actual = DoubleArrays.CountNumberOfElementsGreaterAllNeighbors(array);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(0)]
        [TestCase(8)]
        public static void GetNumberOfElemInArrayThatLargerThanAllTheirNeighbors_WhenArrayPassed_ReturnArgumentException(int mockNumber)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                int[,] array = DoubleArrayMock.GetMock(mockNumber);
                int actual = DoubleArrays.CountNumberOfElementsGreaterAllNeighbors(array);
            });
        }

        [TestCase(1, 3)]
        [TestCase(2, 4)]
        [TestCase(5, 6)]
        public static void FlipArrayDiagonally_WhenArrayPassed_ReturnArrayRelativeToMainDiagonal(int mockNumber, int mockExpected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);
            int[,] expected = DoubleArrayMock.GetMock(mockExpected);
            int[,] actual = DoubleArrays.FlipArrayDiagonally(array);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(0)]
        [TestCase(8)]
        public static void FlipArrayDiagonally_WhenArrayPassed_ReturnArgumentExceptio(int mockNumber)
        {
            Assert.Throws<ArgumentNullException>(() =>
           {
               int[,] array = DoubleArrayMock.GetMock(mockNumber);
               int[,] actual = DoubleArrays.FlipArrayDiagonally(array);
           });
        }

    }

    class DoubleArrayMock
    {
        public static int[,] GetMock(int num)
        {
            int[,] result = new int[0,0];
            switch (num)
            {
                case 0:
                    result = new int[,] { };
                    break;
                case 1:
                    result = new int[,] {
                        { 1,2,3 },
                        { 4,5,6 },
                        { 7,8,9 }
                    };
                    break;
                case 2:
                    result = new int[,] {
                        { 1,1,2 },
                        { 2,2,2 }
                    };
                    break;
                // 3=1(flip)
                case 3:
                    result = new int[,] {
                        { 1,4,7 },
                        { 2,5,8 },
                        { 3,6,9 }
                    };
                    break;
                // 4=2(flip)
                case 4:
                    result = new int[,] {
                        { 1,2 },
                        { 1,2 },
                        { 2,2 }
                    };
                    break;
                case 5:
                    result = new int[,] {
                        { 1,2 }
                    };
                    break;
                case 6:
                    result = new int[,] {
                        { 1 },
                        { 2 }
                    };
                    break;
                case 7:
                    result = new int[,] {
                        { 10, 4, 11 },
                        { 2, 9, 8 },
                        { 13, 6, 19 }
                    };
                    break;

                case 8:
                    result = null;
                    break;

            }
            return result;
        }
    }
}
