// /****************************** Module Header ******************************\
// Module Name:  Module2_SelfAssessmentLab.cs
// Project:      edX_DEV204.3x
// Copyright (c) Shaan Foltz
//
// Description:  
//
//
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
// WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// \***************************************************************************/
using System;
using System.Collections.Generic;

namespace edX_DEV204
{
    public class Module2_SelfAssessmentLab
    {
        public Module2_SelfAssessmentLab()
        {
        }

        public struct Student
        {
            public string firstName;
            public string lastName;

            public void Study()
            {
                Console.WriteLine("The student is studying.");
            }
        }

        public struct Teacher
        {
            public string firstName;
            public string lastName;

            public void GradeAssignments()
            {
                Console.WriteLine("The teacher is grading.");
            }
        }

        public void StartLab()
        {
            Student[] aStudents = new Student[5];
            aStudents[0].firstName = "Max";
            aStudents[0].lastName = "Amillion";
            aStudents[1].firstName = "John";
            aStudents[1].lastName = "Doe";
            aStudents[2].firstName = "Sally";
            aStudents[2].lastName = "Shareholder";
            aStudents[3].firstName = "Finn";
            aStudents[3].lastName = "Finley";
            aStudents[4].firstName = "Lisa";
            aStudents[4].lastName = "Simpson";

            foreach (Student s in aStudents)
            {
                Console.WriteLine("{0} {1}", s.firstName, s.lastName);
            }

        }

        public  int ComputeAverage(int[] a){
            double averageAsDouble = -1;
            int sum = 0;

            foreach(int i in a){
                sum += i;
            }
            averageAsDouble = Math.Round(((double)sum / a.Length),MidpointRounding.ToEven);
            return (int)averageAsDouble;
        }

        public string Reversal(string s)
        {
            // reverse all but the first and last characters of a string
            char[] inputArray = s.ToCharArray();
            Array.Reverse(inputArray);
            char first = inputArray[0];
            char last = inputArray[inputArray.Length - 1];
            inputArray[0] = last;
            inputArray[inputArray.Length - 1] = first;

            return new string(inputArray);
        }

        public int Ksmallest(int[] a, int k)
        {
            int kSmallest;

            Array.Sort(a);
            HashSet<int> hash = new HashSet<int>(a);
            int[] a2 = new int[hash.Count];
            hash.CopyTo(a2);
            kSmallest = a2[k - 1];

            return kSmallest;
        }

        public int Difference(int[] a)
        {
            // Find maximum difference between 2 elements in an integer array. 
            // You may assume the array contains no less than two elements.
            int maxDiff = -1;
            for (int i = 0; i < a.Length;i++){
                // loop through each element in the array
                // and compare that element with all the others (get the diff)
                int thisNumber = a[i];
                for (int j = 0; j < a.Length;j++){
                    if (maxDiff < Math.Abs(thisNumber-a[j])){
                        maxDiff = Math.Abs(thisNumber - a[j]);
                    }
                }
            }
            return maxDiff;
        }

        public int Parentheses(string s)
        {
            // Count the depth of nesting parentheses in a string. 
            // If a string contains unmatched parentheses, 
            // count its depth to be 0.
            int depthOfParens = 0;
            int maxDepth = 0;
            int open = 0;
            int closed = 0;


            //List<char> thisStringAsChars = new List<char>(s);
            foreach (char c in s){
 
                switch (c){
                    case '(':
                        open++;
                        depthOfParens++;
                        if (depthOfParens > maxDepth) maxDepth = depthOfParens;
                        break;
                    case ')':
                        closed++;
                        depthOfParens--;
                        open--;
                        break;
                    default:
                        break;
                }
           }
            if (open == 0) depthOfParens = 0; // reset
            if (open != 0) maxDepth = 0;
            return maxDepth;
        }

    }
}
