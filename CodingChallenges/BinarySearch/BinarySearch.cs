using System;

namespace CodingChallenges.BinarySearch
{
    internal class Program
    {
        internal static void BinarySearch()
        {
            //Set-up Array and Value to Search
            var bogus = new BogusModelGenerators();

            var array = bogus.Array_CreateIntArray(10);
            var value = bogus.Array_GetRandomValue(array);
         
            Console.WriteLine($"Array: [{string.Join(", ", array)}]");
            Console.WriteLine($"Search Value: {value}");


            //Binary Search
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (array[middle] == value)
                {
                    Console.WriteLine($"Value: {value} found at Index: {middle}");
                    break;
                }
                else if (array[middle] < value)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
        }
    }
}