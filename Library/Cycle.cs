using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Cycle
    {
        public static int GetAtoPowB(int a, int b)
        {
            int result=1;

            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }
        public static int[] GetNumbersFrom1To1000DividedA(int a)
        {
           
            if (a != 0 && a <= 1000)
            {
                int[] array = new int[1000 / a];
                int j = 0;
                for (int i = a; i <= 1000; i += a)
                {
                    array[j] = i;
                    ++j;
                }
                return array;
            }
            else
            {
                throw new ArgumentException("a==0 or a>1000");
            }
        }
        public static int FindAmountOfNumbersWhoseSquareLessA(int a)
        {

        int quantity = 0;

            for (int i = 1; i < a; i++)
            {
                if (i * i < a)
                {
                    quantity++;
                }
            }
            return quantity;
        }
        public static int FindGreatestDivisorForA(int a)
        {
            int imax = 0;

            for (int i = 1; i < a; i++)
            {

                if (a % i == 0)
                {
                    imax = i;
                }
            }
            return imax;
        }
        public static int FindSumOfAllNumsThatDivideBy7(int numA, int numB)
        {
            int sum = 0;

            if (numA > numB)
            {
                for (int i = numB; i < numA; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }
            else if (numA<numB)
            {
                for (int i = numA; i < numB; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }
            else
            {
                throw new ArgumentException("a=b");
            }
        }
        public static int GetNumFibonachi(int num)
        {
            
            int a = 1;
            int b = 1;
            int Nfib;
            

            for (int i = 1; i < num; i++)
            {
                Nfib = a;
                a = b;
                b += Nfib;
            }
            return b;
        }

        public static int GetEuclideanAlgorithm(int numA, int NumB)
        {
            while (numA != NumB)
            {
                if (numA > NumB)
                {
                    numA -= NumB;
                }
                else
                {
                    NumB -= numA;
                }
            }
            return numA;
        }
        public static int GetHalfDivisionMethod(int num)
        {
            int left = 0;
            int right = num;
            int middle = right;
            int cube = 0;
            int result = 0;

            while (cube != num)
            {
                cube = middle * middle * middle;
                if (num < cube)
                {
                    right = middle;
                }
                else if (num > cube)
                {
                    left = middle;
                }
                else if (num == cube)
                {
                    result = middle;
                    break;
                }
                middle = (left + right) / 2;
            }
            return result;
        }
        public static int FindNumberOfOdd(int num)
        {
            int result = 0;

            while (num != 0)
            {
                int b = num % 10;

                num /= 10;
                if (b % 2 != 0)
                {
                    result++;
                }
            }
            return result;
        }
        public static int GetMirrorMumber(int num)
        {
            int revers = 0;

            while (num != 0)
            {
                revers += num % 10;
                revers *= 10;
                num /= 10;
            }
            revers /= 10;
            return revers;
        }
        public static int[] FindNumbersAmountOfEvenGreaterThanOdd(int num)
        {
            int sumEven = 0;
            int sumNotEven = 0;
            int result;
            int count = 0;

            for (int i = 1; i < num; i++)
            {
                int temp = i;
                while (temp > 0)
                {
                    result = temp % 10;
                    if (result % 2 == 0)
                    {
                        sumEven += result;
                    }
                    else
                    {
                        sumNotEven += result;
                    }
                    temp /= 10;
                }
                if (sumEven > sumNotEven)
                {
                    ++count;
                }

                sumEven = 0;
                sumNotEven = 0;

            }

            int[] array = new int[count];
            int j = 0;

            for (int i = 1; i < num; i++)
            {
                int temp = i;
                while (temp > 0)
                {
                    result = temp % 10;
                    if (result % 2 == 0)
                    {
                        sumEven += result;
                    }
                    else
                    {
                        sumNotEven += result;
                    }
                    temp /= 10;
                }
                if (sumEven > sumNotEven)
                {
                    array[j++] = i;
                }

                sumEven = 0;
                sumNotEven = 0;
            }

            return array;
        }
        public static string FindIdenticalNumbers(string a, string b)
        {
            bool tmp = false;

            foreach (var itemA in a)
            {

                foreach (var itemB in b)
                {
                    if (itemA == itemB)
                    {
                        tmp = true;
                        break;
                    }
                }
            }
            if (tmp)
            {
                return ("Yes");
            }
            else
            {
               return ("No");
            }
        }
    }
}
