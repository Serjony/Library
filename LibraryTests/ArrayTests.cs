using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Tests
{
    class ArrayTests
    {
        [TestCase(2, 2)]
        [TestCase(3, 0)]
        [TestCase(4, 3)]
        public void GetMinElementInArray_WhenArrayPassed_ReturnMinElemnet(int mockNumber, int expected)
        {
            int[] array = ArrayMock.GetMock(mockNumber);
            int actual = Arrays.FindMinElemInArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 127)]
        [TestCase(3, 335)]
        [TestCase(4, 92)]
        public void GetMaxElementInArray_WhenArrayPassed_ReturnMaxElemnet(int mockNumber, int expected)
        {
            int[] array = ArrayMock.GetMock(mockNumber);
            int actual = Arrays.FindMaxElemInArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 4)]
        [TestCase(3, 0)]
        [TestCase(4, 2)]
        public void GetIndexOfMinElementInArray_WhenArrayPassed_ReturnIndexOfMinElemnet(int mockNumber, int expected)
        {
            int[] array = ArrayMock.GetMock(mockNumber);
            int actual = Arrays.FindIndexForMinNumber(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(4, 1)]
        public void GetIndexOfMaxElementInArray_WhenArrayPassed_ReturnIndexOfMaxElemnet(int mockNumber, int expected)
        {
            int[] array = ArrayMock.GetMock(mockNumber);
            int actual = Arrays.FindIndexForMaxNumber(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 293)]
        [TestCase(3, 464)]
        [TestCase(4, 128)]
        public void GetOddSumInArray_WhenArrayPassed_ReturnOddSum(int mockNumber, int expected)
        {
            int[] array = ArrayMock.GetMock(mockNumber);
            int actual = Arrays.CalculateSumOfOddInArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 })]
        [TestCase(3, new int[] { 8, 41, 6, 335, 1, 56, 13, 32, 0 })]
        [TestCase(4, new int[] { 23, 36, 3, 92, 16 })]
        public void GetReverseArray_WhenArrayPassed_ReturnReverseArray(int mockNumber, int[] expected)
        {
            int[] array = ArrayMock.GetMock(mockNumber);
            int[] actual = Arrays.GetReverseArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 5)]
        [TestCase(3, 4)]
        [TestCase(4, 2)]
        public void GetNumberOfOddElemenInArray_WhenArrayPassed_ReturnNumberOfOdd(int mockNumber, int expected)
        {
            int[] array = ArrayMock.GetMock(mockNumber);
            int actual = Arrays.GetNumberOfOddElementsInArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 5, 6, 7, 8, 9, 0, 1, 2, 3, 4 })]
        [TestCase(3, new int[] { 335, 6, 41, 8, 1, 0, 32, 13, 56 })]
        [TestCase(4, new int[] { 36, 23, 3, 16, 92 })]
        public void GetSwapSidesOfArray_WhenArrayPassed_ReturnSwapSidesOfArray(int mockNumber, int[] expected)
        {
            int[] array = ArrayMock.GetMock(mockNumber);
            int[] actual = Arrays.SwapSidesOfArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 2, 5, 16, 22, 34, 44, 69, 73, 101, 127 })]
        [TestCase(3, new int[] { 0, 1, 6, 8, 13, 32, 41, 56, 335 })] 
        [TestCase(4, new int[] { 3, 16, 23, 36, 92 })] 
        public void GetSortArrayBySelection_WhenArrayPassed_ReturnSortedArray(int mockNumber, int[] expected)
        {
            int[] array = ArrayMock.GetMock(mockNumber);
            int[] actual = Arrays.SortArrayBySelection(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 127, 101, 73, 69, 44, 34, 22, 16, 5, 2 })] 
        [TestCase(3, new int[] { 335, 56, 41, 32, 13, 8, 6, 1, 0 })] 
        [TestCase(4, new int[] { 92, 36, 23, 16, 3 })] 
        public void GetSortArrayByInsert_WhenArrayPassed_ReturnSortedArray(int mockNumber, int[] expected)
        {
            int[] array = ArrayMock.GetMock(mockNumber);
            int[] actual = Arrays.SortArrayByInsert(array);

            Assert.AreEqual(expected, actual);
        }

    }
    class ArrayMock
    {
        public static int[] GetMock(int num)
        {
            int[] result = new int[0];
            switch (num)
            {
                case 0:
                    result = new int[] { };
                    break;

                case 1:
                    result = new int[] {0,1,2,3,4,5,6,7,8,9 };
                    break;

                case 2:
                    result = new int[] { 34, 5, 69, 127, 2, 101, 22, 16, 73, 44 };
                    break;

                case 3:
                    result = new int[] { 0, 32, 13, 56, 1, 335, 6, 41, 8};
                    break;

                case 4:
                    result = new int[] { 16, 92, 3, 36, 23};
                    break;
            }
            return result;
        }
    }
}
