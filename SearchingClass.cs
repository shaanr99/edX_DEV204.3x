/****************************** Module Header ******************************\
Module Name:  SearchingClass.cs
Project:      edX_DEV204.3x
Copyright (c) Shaan Foltz

SearchingClass - examples of different types of searching methods.


THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/
using System;
namespace edX_DEV204
{
    public class SearchingClass
    {
        public SearchingClass()
        {
        }
        public void LinearSearch(){
            // step through the list starting at 
            // the beginning until a match is found

            // declare an array of integers that are not sorted
            int[] nums = { 5, 10, 3, 4, 2 };
            int searchTerm = 4;

            Console.Write("Given Array: ");
            foreach (int val in nums)
            {
                Console.Write(val + ", ");
            }

            Console.WriteLine("Search Term: " + searchTerm);

            for (int i = 0; i < nums.Length - 1;i++){
                // compare the number at location i 
                // with the searchTerm
                if (searchTerm == nums[i])
                {
                    Console.WriteLine("Match found at index i = " + i);
                    break;
                }
                else {
                    Console.WriteLine("No match at i = " + i);
                }
            }
        }  // end linear search

        public void BinarySearch(){
            // keep chopping the list in half until a match results
            // ONLY works if the list is sorted

            // declare an array of integers that are not sorted
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 14 };
            int searchTerm = 4;

            Console.Write("Given Array: ");
            foreach (int val in nums)
            {
                Console.Write(val + ", ");
            }

            Console.WriteLine("Search Term: " + searchTerm);

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                // compare the search term to the middle value
                Console.WriteLine("left = " + left + " middle = " + middle + "right = " + right);
                if (searchTerm == nums[middle]){
                    // we got a match
                    Console.WriteLine("Match found at index = " + middle);
                    break;
                }
                else if (searchTerm < nums[middle])
                {
                    right = middle - 1;
                }
                else {
                    left = middle + 1;
                }
             } 

        } // end binary search
    }
}
