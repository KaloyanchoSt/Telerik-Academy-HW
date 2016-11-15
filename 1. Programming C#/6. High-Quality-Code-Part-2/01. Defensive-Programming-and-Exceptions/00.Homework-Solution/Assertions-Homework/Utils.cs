namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;

    public static class Utils
    {
        public static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
    where T : IComparable<T>
        {
            Debug.Assert(arr != null, "The array to sort cannot be null!");
            Debug.Assert(arr.Length > 0, "The array to sort must contain elements!");
            Debug.Assert(startIndex < arr.Length && startIndex >= 0, "Start index must be between 0 and arr length!");
            Debug.Assert(endIndex < arr.Length && endIndex >= 0, "End index must be between 0 and arr length!");
            Debug.Assert(startIndex <= endIndex, "Start index must be less or equal to End index!");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }
            return minElementIndex;
        }

        public static void Swap<T>(ref T x, ref T y)
        {
            Debug.Assert(x != null && y != null, "The value to swap cannot be null");

            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
