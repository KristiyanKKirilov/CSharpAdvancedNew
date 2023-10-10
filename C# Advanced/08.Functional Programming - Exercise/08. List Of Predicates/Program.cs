﻿using System;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Predicate<int>> predicates = new();

            int n = int.Parse(Console.ReadLine());

            HashSet<int> divideNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

            int[] numbers = Enumerable.Range(1, n).ToArray();

            foreach (var divider in divideNumbers)
            {
                predicates.Add(n => n % divider == 0);
            }
            foreach (var number in numbers)
            {
                bool isDivisible = true;

                foreach (var match in predicates)
                {
                    if (!match(number))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    Console.Write($"{number} ");
                }
            }




        }
    }
}