// /****************************** Module Header ******************************\
// Module Name:  CollectionsClass.cs
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

using static edX_DEV204.DataStructuresClass;

namespace edX_DEV204
{
    public class CollectionsClass
    {
        public CollectionsClass()
        {
            
        }

        public void PlayWithArrayLists(){
            Console.WriteLine();
            Console.WriteLine("Playing with ArrayLists ... ");

            // Create a new ArrayList collection.
            ArrayList beverages = new ArrayList();


            // Create some items to add to the collection.
            Coffee coffee1 = new Coffee(4, "Arabica", "Columbia");
            Coffee coffee2 = new Coffee(3, "Arabica", "Vietnam");
            Coffee coffee3 = new Coffee(4, "Robusta", "Indonesia");


            // Add the items to the collection.
            // Items are implicitly cast to the Object type when you add them.
            beverages.Add(coffee1);
            beverages.Add(coffee2);
            beverages.Add(coffee3);


            // Retrieve items from the collection.
            // Items must be explicitly cast back to their original type.
            Coffee firstCoffee = (Coffee)beverages[0];
            Coffee secondCoffee = (Coffee)beverages[1];

            // Iterating Over a List Collection
            foreach (Coffee coffee in beverages)
            {
                Console.WriteLine("Bean type: {0}", coffee.Bean);
                Console.WriteLine("Country of origin: {0}", coffee.CountryOfOrigin);
                Console.WriteLine("Strength (1-5): {0}", coffee.Strength);
            }
        }

        public void PlayWithHashTables(){
            // Create a new Hashtable collection.
            Hashtable ingredients = new Hashtable();


            // Add some key/value pairs to the collection.
            ingredients.Add("Café au Lait", "Coffee, Milk");
            ingredients.Add("Café Mocha", "Coffee, Milk, Chocolate");
            ingredients.Add("Cappuccino", "Coffee, Milk, Foam");
            ingredients.Add("Irish Coffee", "Coffee, Whiskey, Cream, Sugar");
            ingredients.Add("Macchiato", "Coffee, Milk, Foam");


            // Check whether a key exists.
            Console.WriteLine();
            Console.WriteLine("Check whether a key exists ... ");
            if (ingredients.ContainsKey("Café Mocha"))
            {
                // Retrieve the value associated with a key.
                Console.WriteLine("The ingredients of a Café Mocha are: {0}", ingredients["Café Mocha"]);
            }

            // Iterating Over a Dictionary Collection
            Console.WriteLine();
            Console.WriteLine("Iterating Over a Dictionary Collection ... ");
            foreach (string key in ingredients.Keys)
            {
                // For each key in turn, retrieve the value associated with the key.  
                Console.WriteLine("The ingredients of a {0} are {1}", key, ingredients[key]);
            }
        }

        public void PlayWithLambdas(){
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { empID = 001, Name = "Tom", Department= "Sales"},
                new Employee() { empID = 024, Name = "Joan", Department= "HR"},
                new Employee() { empID = 023, Name = "Fred", Department= "Accounting" },
                new Employee() { empID = 040, Name = "Mike", Department= "Sales" },
            };


            // Find the member of the list that has an employee id of 023
            Employee match = employees.Find((Employee p) => { return p.empID == 023; });
            Console.WriteLine("empID: {0}\nName: {1}\nDepartment: {2}", match.empID, match.Name, match.Department);
        }

        private struct Employee {
            public int empID;
            public string Name;
            public string Department;

            public Employee(int _empID, string _Name, string _Department){
                empID = _empID;
                Name = _Name;
                Department = _Department;
            }
        }

    }
}
