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
using System.Collections;
using System.Collections.Generic;

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
            //DataStructuresClass dsc = new DataStructuresClass();

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

            //CollectionsClass cc = new CollectionsClass();
            //Console.WriteLine("Playing with an ArrayList ...");
            //cc.PlayWithArrayLists();

            //Console.WriteLine("Playing with a HashTable ...");
            //cc.PlayWithHashTables();

            //Console.WriteLine("Playing with a Lambdas ...");
            //cc.PlayWithLambdas();

            //CollectionsTutorialClass collLab = new CollectionsTutorialClass();
            //collLab.LabOne();
            //collLab.LabTwo();

            //// Module 3 Assessment Lab
            //SampleStudent student1 = new SampleStudent("John", "Doe");
            //SampleStudent student2 = new SampleStudent("Sally", "Seaward");
            //SampleStudent student3 = new SampleStudent("Colin", "Carnivore");

            //ArrayList students = new ArrayList();
            //student1.Grades.Push(67);
            //student1.Grades.Push(97);
            //student1.Grades.Push(100);
            //student1.Grades.Push(56);
            //student1.Grades.Push(87);

            //student2.Grades.Push(100);
            //student2.Grades.Push(99);
            //student2.Grades.Push(95);
            //student2.Grades.Push(100);
            //student2.Grades.Push(89);

            //student3.Grades.Push(80);
            //student3.Grades.Push(87);
            //student3.Grades.Push(85);
            //student3.Grades.Push(76);
            //student3.Grades.Push(89);

            //students.Add(student1);
            //students.Add(student2);
            //students.Add(student3);

            //foreach(SampleStudent s in students){
            //    Console.WriteLine();
            //    Console.Write("First Name:  {0}, Last Name: {1}, Grades:  ", s.FirstName, s.LastName);
            //    foreach(int grade in s.Grades){
            //        Console.Write("{0}, ", grade);
            //    }
            //}

            //// GENERICS
            //GenericsClass gen = new GenericsClass();
            //gen.TypeSafetyExampleOne();
            //gen.UsingTheListClass();
            //gen.UsingTheDictionaryClass();

            //// Generic List<T> Lab
            //List<Student> students = new List<Student>();
            //Student stud1 = new Student("Tom", "Thumb", 12, "Computer Science");
            //Student stud2 = new Student("Fred", "Flintstone", 45, "Geology");
            //Student stud3 = new Student("Mickey", "Mouse", 35, "Animation");

            //students.Add(stud1);
            //students.Add(stud2);
            //students.Add(stud3);

            //foreach (Student stud in students){
            //    Console.WriteLine(stud.FirstName);
            //}

            //// check for existance
            //bool exists = students.Contains(stud1);
            //Console.WriteLine(exists.ToString());

            //// remove a student
            //Console.WriteLine(students.Count);
            //students.Remove(stud3);
            //Console.WriteLine(students.Count);

            ModuleFourAssessment mfa = new ModuleFourAssessment();
            mfa.Lab();
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
