namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Utils
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null || arr.Length <= 0)
            {
                throw new ArgumentNullException("The array to subsequence cannot be null or empty!");
            }

            if (startIndex < 0 || startIndex >= arr.Length)
            {
                throw new IndexOutOfRangeException("Startindex cannot be less than 0 or more than the length of the array!");
            }

            if (count < 0 || count >= arr.Length)
            {
                throw new IndexOutOfRangeException("Count cannot be less than 0 or more than the length of the array!");
            }

            if (startIndex + count > arr.Length)
            {
                throw new IndexOutOfRangeException("Startindex + count cannot be more than the length of the array!");
            }
            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }
            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (count > str.Length)
            {
                throw new IndexOutOfRangeException("Count cannot be more than the length of the string!");
            }

            if (count < 0)
            {
                throw new IndexOutOfRangeException("Count cannot be less than 0!");
            }

            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentNullException("The string cannot be null or empty!");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }
            return result.ToString();
        }

        public static void CheckPrime(int number)
        {
            if (number < 2)
            {
                throw new ArgumentOutOfRangeException("The prime number cannot be less than 2!");
            }

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    throw new Exception("The number is not prime!");
                }
            }
        }
    }
}
