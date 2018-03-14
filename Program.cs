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

            // STRUCTURES
            dsc.PlayWithStructs();

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
