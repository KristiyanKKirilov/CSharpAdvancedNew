﻿using System;

namespace CustomComparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int, int> compare = (x, y) =>
            //{
            //    if (x % 2 == 0 && y % 2 != 0)
            //    {
            //        return -1;
            //    }
            //    if (x % 2 != 0 && y % 2 == 0)
            //    {
            //        return 1;
            //    }

            //    return x.CompareTo(y);
            //};

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            Array.Sort(numbers, new Comparer());

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
     class Comparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x % 2 == 0 && y % 2 != 0)
            {
                return -1;
            }
            if (x % 2 != 0 && y % 2 == 0)
            {
                return 1;
            }

            return x.CompareTo(y);
        }
    }
}