namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;

    public static class SearchingAlgorithms
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array cannot be null");
            Debug.Assert(arr.Length > 0, "The array is empty");
            Debug.Assert(value != null, "The value cannot be null!");

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array cannot be null");
            Debug.Assert(arr.Length > 0, "The array is empty");
            Debug.Assert(value != null, "The value cannot be null");
            Debug.Assert(startIndex < arr.Length && startIndex >= 0, "Start index must be between 0 and array length!");
            Debug.Assert(endIndex < arr.Length && endIndex >= 0, "End index must be between 0 and array length!");
            Debug.Assert(startIndex <= endIndex, "Start index must be less or equal to End index!");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }
                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}
