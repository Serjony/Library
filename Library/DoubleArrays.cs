using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class DoubleArrays
    {
        public static int FindMinElementInDoubleArray(int[,] array)
        {
            
            int min = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{ array[i, j]} ");

                    if (min > array[i, j])
                    {
                        min = array[i, j];

                    }
                }
                Console.WriteLine();
            }
            return min;
        }

        public static int FindMaxElementInDoubleArray(int[,] array)
        {
            
            int max = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{ array[i, j]} ");

                    if (max < array[i, j])
                    {
                        max = array[i, j];

                    }
                }
                Console.WriteLine();
            }
            return max;
        }

        public static int[] FindIndexOfMinElementInDoubleArray(int[,] array)
        {
            
            int indexI = 0;
            int indexJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{ array[i, j]} ");

                    if (array[indexI, indexJ] > array[i, j])
                    {
                        
                        indexI = i;
                        indexJ = j;
                    }
                }
                Console.WriteLine();
            }
            return new int[2] { indexI, indexJ };
        }

        public static int[] FindIndexOfMaxElementInDoubleArray(int[,] array)
        {
            
            
            int indexI=0;
            int indexJ=0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{ array[i, j]} ");

                    if (array[indexI, indexJ] < array[i, j])
                    {
                        indexI = i;
                        indexJ = j;
                       
                    }
                }
                Console.WriteLine();
            }
            return new int[] { indexI, indexJ };
        }

        public static int[,] FlipArrayDiagonally(int[,] array)
        {
            
            int[,] array2 = new int[array.GetLength(1), array.GetLength(0)];
           

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array2[j, i] = array[i, j];
                }
                
            }
            return array2;
        }

        public static int CountNumberOfElementsGreaterAllNeighbors(int[,] array)
        {
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (((i <= 0 || array[i - 1, j] < array[i, j])
                        && (i >= array.GetLength(0) - 1) || array[i + 1, j] < array[i, j])
                        && (j <= 0 || array[i, j - 1] < array[i, j])
                        && (j >= array.GetLength(1) - 1 || array[i, j + 1] < array[i, j]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        
    }
}
