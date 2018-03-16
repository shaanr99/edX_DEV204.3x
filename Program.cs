/****************************** Module Header ******************************\
Module Name:  Program.cs
Project:      edX_DEV204.3x
Copyright (c) Shaan Foltz

Program - Main entry point


THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/
using System;

namespace edX_DEV204
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting edX_DEV204._3x Examples ...");

            //// SORTING
            //SortingClass sc = new SortingClass();
            //Console.WriteLine("Calling BubbleSort() ...");            
            //sc.BubbleSort();
            //Console.WriteLine("Calling InsertionSort() ...");
            //sc.InsertionSort();
            //Console.WriteLine("Calling SelectionSort() ...");
            //sc.SelectionSort();

            //// SEARCHING
            //SearchingClass searcher = new SearchingClass();
            //Console.WriteLine("Calling LinearSearch() ...");
            //searcher.LinearSearch();
            //Console.WriteLine("Calling BinarySearch() ...");
            //searcher.BinarySearch();

            //// ARRAYS
            //ArraysClass arraysClass = new ArraysClass();
            //int ROWS = 10;
            //int COLS = 10;

            //// Single Array
            //int[] singleArray = arraysClass.CreateSingleArray(ROWS);
            //Console.WriteLine();
            //PrintArray(ArrayType.Single, singleArray);

            //// Multidimensional Array
            //int[ , ] multiArray = arraysClass.CreateMultiArray(ROWS, COLS);
            //Console.WriteLine();
            //PrintArray(ArrayType.Multi, multiArray);

            //// Jagged Array
            //int[][] jaggedArray = arraysClass.CreateJaggedArray(ROWS);
            //Console.WriteLine();
            //PrintArray(ArrayType.Jagged, jaggedArray);

            // MORE DATA STRUCTURES
            DataStructuresClass dsc = new DataStructuresClass();

            //// ENUMERATIONS
            //dsc.PlayWithEnumerations();

            //// STRUCTURES
            //dsc.PlayWithStructs();

            //// HASHTABLES
            //HashTablesClass htc = new HashTablesClass();
            //htc.CreateHashtableExample();
            //htc.StepThroughHashTable();

            // ************ LAB ***************
            //Module2_SelfAssessmentLab lab = new Module2_SelfAssessmentLab();

            //// create an array
            //int[] testArray1 = { 1, 3, 1, 1 };
            //int[] testArray2 = { -3, 2 };
            //int[] testArray3 = { -2, 4, -1, 6 };

            //Console.WriteLine("The computed average for testArray1 is {0}", lab.ComputeAverage(testArray1));
            //Console.WriteLine("The computed average for testArray2 is {0}", lab.ComputeAverage(testArray2));
            //Console.WriteLine("The computed average for testArray3 is {0}", lab.ComputeAverage(testArray3));

            //Console.WriteLine("Input: abcad Output: {0}",lab.Reversal("abcad"));
            //Console.WriteLine("Input: a0b c1d Output: {0}", lab.Reversal("a0b c1d"));
            //Console.WriteLine("Input: ab Output: {0}", lab.Reversal("ab"));
            //Console.WriteLine("Input: a Output: {0}", lab.Reversal("a"));

            //Console.WriteLine("Input: 2, 1, 4 k = 3: {0}",lab.Ksmallest(new int[] { 2, 1, 4 }, 3));
            //Console.WriteLine("Input: 7, 2, 1, 6, 1 k = 3: {0}", lab.Ksmallest(new int[] { 7, 2, 1, 6, 1 }, 3));

            //Console.WriteLine("Input: 3, 2, 9, 5: {0}", lab.Difference(new int[] { 3, 2, 9, 5 }));
            //Console.WriteLine("Input: 1,1,1,1: {0}", lab.Difference(new int[] { 1, 1, 1, 1 }));

            //Console.WriteLine("Input:  a(())b(): Output:  {0}", lab.Parentheses("a(())b()"));
            //Console.WriteLine("Input:  (()1(): Output:  {0}", lab.Parentheses("(()1()"));
            //Console.WriteLine("Input:  (): Output:  {0}", lab.Parentheses("()"));
            //Console.WriteLine("Input:  ()((()))()(): Output:  {0}", lab.Parentheses("()((()))()()"));
            // ************ END LAB ***************

            CollectionsClass cc = new CollectionsClass();
            Console.WriteLine("Playing with an ArrayList ...");
            cc.PlayWithArrayLists();

            Console.WriteLine("Playing with a HashTable ...");
            cc.PlayWithHashTables();


        }

        private static void PrintArray(ArrayType arrayType, Object thisArray){
            switch (arrayType) {
                case ArrayType.Single:
                    int[] sArray = (int[])thisArray;
                    Console.Write("Single array contents:  ");
                    for (int i = 0; i < sArray.Length;i++){
                        Console.Write(sArray[i] + ", ");
                    }
                    break;
                case ArrayType.Multi:
                    int[ , ] mArray = (int[ , ])thisArray;
                    Console.Write("Multi array contents:  ");
                    for (int i = 0; i < mArray.GetLength(0); i++)
                    {
                        Console.WriteLine();
                        for (int j = 0; j < mArray.GetLength(1);j++)
                        Console.Write(mArray[i , j] + ", ");
                    }
                    break;
                case ArrayType.Jagged:
                    int[][] jArray = (int[][])thisArray;
                    Console.Write("Jagged array contents:  ");
                    for (int i = 0; i < jArray.Length; i++)                       
                    {
                        Console.WriteLine();
                        for (int j = 0; j < jArray[i].Length; j++)
                            Console.Write(jArray[i][j] + ", ");
                    }                    break;
                default:
                    break;
                    
            }
        }

        enum ArrayType { Single, Multi, Jagged };
    }
}
