using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Arrays
    {
        public static int FindMinArray(int[] array)
        {
            
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];

                }
            }
            return min;
        }
        public static int FindMaxArray(int[] array)
        {
           
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];

                }
            }
            return max;
        }
        public static int FindIndexForMinNumber(int[] array)
        {
            
            int min = array[0];
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minIndex = i;

                }
            }
            
            return minIndex;
        }
        public static int FindIndexForMaxNumber(int[] array)
        {
           
            int max = array[0];
            int indexMax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    indexMax = i;
                }
            }
            
            return indexMax;
        }
        public static int CalculateSumOfOddInArray(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        public static int[] ReverseArray(int[] array)
        {
            
            int[] reverse = new int[array.Length];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverse[i] = array[array.Length - i - 1];
            }

            return reverse;
        }
        public static int NumberOfOddElementsInArray(int[] array)
        {
            
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum++;
                }
            }
            return sum;
        }
        public static int[] SwapSidesOfArray(int[] array)
        {
            
            int shift = array.Length / 2 + array.Length % 2;

            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[i + shift];
                array[i + shift] = temp;
            }

            return array;
        }

        public static int[] SortArrayBySelection(int[] array)
        {
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;

                if (min > array[i])
                {
                    min = array[i];
                }
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
            return array;
        }
        public static int[] SortArrayByInsert(int[] array)
        {
            
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;

                while (j > 0 && array[j] > array[j - 1])
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;

                    j--;
                }
            }
            return array;
        }
    }
}
