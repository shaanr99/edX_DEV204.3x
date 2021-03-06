﻿// /****************************** Module Header ******************************\
// Module Name:  Student.cs
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
    public class SampleStudent
    {
        public string FirstName;
        public string LastName;
        public SortedSet<int> Grades = new SortedSet<int>();

        public SampleStudent(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
