﻿using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary_Search!");

            int valueToBeFound = 43;
            int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };

            Console.WriteLine("Our array contains: ");
            Array.ForEach(array, x => Console.Write(x + " "));

            Console.Write($"\n\nThe result of a binary search for {valueToBeFound} is located at: ");
            Console.WriteLine(binarySearch(array, valueToBeFound));
        }

        /// <summary>
        /// a = array
        /// x = what we're searching
        /// p = first index
        /// q = midpoint
        /// r = last index
        /// </summary>
        public static int binarySearch(int[] xMyArray, int xSearchValue) {
            // Step 1 - intialize the variables
            int currentMid  = 0;          // beginning of the range
            int maxSize     = xMyArray.Length - 1;  // the end of the range aka last slot
            int returnValue = -1;

            // Step 2 - we do something (search for our value)
            while (currentMid <= maxSize) // when true, we are still in the range
            {
                int newMidPoint = (currentMid + maxSize) / 2; // find the midpoint

                if (xSearchValue < xMyArray[newMidPoint]) 
                {
                    maxSize = newMidPoint - 1;  // set r to mid point. We narrowed to 1st half of the
                                                // array in the case x is less the data in slot q                 
                }
                else if (xSearchValue > xMyArray[newMidPoint]) 
                {
                    currentMid = newMidPoint + 1; // the opposite occurs. we bring p to the right of the array 
                }
                else 
                {
                    returnValue = newMidPoint; // here we found our value b/c x must = q
                    break;
                }
            }
            // Step 3 - indicate not found
            return returnValue;
        }
    }
}
