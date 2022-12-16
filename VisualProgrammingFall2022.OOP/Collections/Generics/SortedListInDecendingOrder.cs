/*
    Author      : Aamir Pare
    Description : Working with SortedList  
    Date        : 20/10/2022
    Location    : G-11/4 Home, Islamabad
*/

//Topic : How to sort the generic SortedList in the descending order?

using System;
using System.Collections.Generic;

namespace VisualProgrammingFall2022.OOP.Collections.Generics
{
    public class DecendingComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }
    public class SortedListInDecendingOrder
    {
        public static void Main(string[] args)
        {
            var comparer = Comparer<int>.Create((x, y) => y.CompareTo(x));

            //SortedList<int, int> list = new SortedList<int, int>(new DecendingComparer());
            SortedList<int, int> list = new SortedList<int, int>(comparer)
            {
                { 1, 4},
                { 20, 24},
                { 300, 14},
                { 40, 40}
            };

            foreach (var kvp in list)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            //writecode here
            Console.ReadKey();
        }
    }
}
