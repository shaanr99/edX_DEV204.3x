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


    }
}
