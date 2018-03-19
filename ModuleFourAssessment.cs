// /****************************** Module Header ******************************\
// Module Name:  ModuleFourAssessment.cs
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
using System.Collections;
using System.Collections.Generic;

namespace edX_DEV204
{
    public class ModuleFourAssessment
    {
        public ModuleFourAssessment()
        {
        }

        public void Lab(){
            SampleStudent s1 = new SampleStudent("John", "Doe");
            SampleStudent s2 = new SampleStudent("Sally", "Slither");
            SampleStudent s3 = new SampleStudent("Geraldo", "Gorgonzola");

            List<SampleStudent> students = new List<SampleStudent>();
            s1.Grades.Add(67);
            s1.Grades.Add(97);
            s1.Grades.Add(100);
            s1.Grades.Add(56);
            s1.Grades.Add(87);

            s2.Grades.Add(100);
            s2.Grades.Add(99);
            s2.Grades.Add(95);
            s2.Grades.Add(100);
            s2.Grades.Add(89);

            s3.Grades.Add(80);
            s3.Grades.Add(87);
            s3.Grades.Add(85);
            s3.Grades.Add(76);
            s3.Grades.Add(89);

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);

            foreach (SampleStudent s in students)
            {
                Console.WriteLine();
                Console.Write("First Name:  {0}, Last Name: {1}, Grades:  ", s.FirstName, s.LastName);
                foreach (int grade in s.Grades)
                {
                    Console.Write("{0}, ", grade);
                }
            }

            //s1.Grades.Pop();
            //s2.Grades.Pop();
            //s3.Grades.Pop();
            //s1.Grades.Push(100);
            //s2.Grades.Push(100);
            //s3.Grades.Push(100);

            //Console.WriteLine();

            //foreach (SampleStudent s in students)
            //{
            //    Console.WriteLine();
            //    Console.Write("First Name:  {0}, Last Name: {1}, Grades:  ", s.FirstName, s.LastName);
            //    foreach(int grade in s.Grades){
            //        Console.Write("{0}, ", grade);
            //    }
            //}

        }
    }
}
