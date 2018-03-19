// /****************************** Module Header ******************************\
// Module Name:  GenericsLab.cs
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
namespace edX_DEV204
{
    public class GenericsLab
    {
        public GenericsLab()
        {
        }
    }

    class Student
    {
        public Student(string first, string last, int age, string prog)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Age = age;
            this.Program = prog;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Program { get; set; }
    }
}
