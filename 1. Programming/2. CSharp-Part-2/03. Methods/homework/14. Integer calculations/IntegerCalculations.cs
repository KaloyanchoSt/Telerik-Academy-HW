using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.Integer_calculations
{
    class IntegerCalculations
    {
        static void Main()
        {
            int[] arrayOfInts = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            Console.WriteLine(Min(arrayOfInts));
            Console.WriteLine(Max(arrayOfInts));
            Console.WriteLine("{0:f2}", Average(arrayOfInts));
            Console.WriteLine(Sum(arrayOfInts));
            Console.WriteLine(Product(arrayOfInts));
        }

        static int Min(params int[] numArray)
        {
            return numArray.Min();
        }
        static int Max(params int[] array)
        {
            return array.Max();
        }
        static double Average(params int[] numArray)
        {
            List<int> list = numArray.ToList();
            return list.Average();
        }
        static long Sum(params int[] numArray)
        {
            return numArray.Sum();
        }
        static long Product(params int[] numArray)
        {
            long product = 1;
            foreach (var item in numArray)
            {
                product *= item;
            }
            return product;
        }
    }
}