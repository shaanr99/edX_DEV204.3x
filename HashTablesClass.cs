// /****************************** Module Header ******************************\
// Module Name:  HashTablesClass.cs
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

namespace edX_DEV204
{
    public class HashTablesClass
    {
        public HashTablesClass()
        {

        }

        private static Hashtable employees = new Hashtable();
        public void CreateHashtableExample()
        {
            // Add some values to the Hashtable, indexed by a string key
            employees.Add("111-22-3333", "Scott");
            employees.Add("222-33-4444", "Sam");
            employees.Add("333-44-55555", "Jisun");

            // Access a particular key
            if (employees.ContainsKey("111-22-3333"))
            {
                string empName = (string)employees["111-22-3333"];
                Console.WriteLine("Employee 111-22-3333's name is: " + empName);
            }
            else
                Console.WriteLine("Employee 111-22-3333 is not in the hash table...");
        }

        public void StepThroughHashTable(){
            // Step through all items in the Hashtable
            foreach (string key in employees.Keys)
                Console.WriteLine("Value at employees[\"" + key + "\"] = " + employees[key].ToString());
        }
    }
}
