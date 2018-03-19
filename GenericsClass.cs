// /****************************** Module Header ******************************\
// Module Name:  GenericsClass.cs
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
    public class GenericsClass
    {
        public GenericsClass()
        {
        }

        public void TypeSafetyExampleOne(){
            // Type Safety Limitations for Non-Generic Collections
            var coffee1 = new Coffee();
            var coffee2 = new Coffee();
            var tea1 = new Tea();
            var arrayList1 = new ArrayList();
            arrayList1.Add(coffee1);
            arrayList1.Add(coffee2);
            arrayList1.Add(tea1);
            // The Sort method throws a runtime exception because the collection is not homogenous.
            try
            {
                arrayList1.Sort();
                // The cast throws a runtime exception because you cannot cast a Tea instance to a Coffee instance.
                Coffee coffee3 = (Coffee)arrayList1[2];
            }
            catch (Exception e){
                Console.WriteLine("This code WILL produce an exception.  {0}", e.Message);
            }
        }

        public void TypeSafetyExampleTwo(){
            // Type Safety in Generic Collections
            var coffee1 = new Coffee();
            var coffee2 = new Coffee();
            var tea1 = new Tea();
            var genericList1 = new List<Coffee>();
            genericList1.Add(coffee1);
            genericList1.Add(coffee2);
            // This line causes a build error, as the argument is not of type Coffee.
            //genericList1.Add(tea1);
            // The Sort method will work because the collection is guaranteed to be homogenous.
            genericList1.Sort();
            // The indexer returns objects of type Coffee, so there is no need to cast the return value.
            //Coffee coffee3 = genericList[1];
        }

        public void BoxAndUnbox(){
            // Boxing and unboxing incurs a 
            // LARGE PERFORMANCE HIT/COMPUTATIONAL COST

            // Boxing and Unboxing: Generic vs. Non-Generic Collections
            int number1 = 1;
            var arrayList1 = new ArrayList();
            // This statement boxes the Int32 value as a System.Object.
            arrayList1.Add(number1);
            // This statement unboxes the Int32 value.
            int number2 = (int)arrayList1[0];
            var genericList1 = new List<Int32>();
            //This statement adds an Int32 value without boxing.
            genericList1.Add(number1);
            //This statement retrieves the Int32 value without unboxing.
            int number3 = genericList1[0];

        }

        public void UsingTheListClass(){
            // Using the List<T> Class
            string s1 = "Latte";
            string s2 = "Espresso";
            string s3 = "Americano";
            string s4 = "Cappuccino";
            string s5 = "Mocha";
            // Add the items to a strongly-typed collection.
            var coffeeBeverages = new List<String>();
            coffeeBeverages.Add(s1);
            coffeeBeverages.Add(s2);
            coffeeBeverages.Add(s3);
            coffeeBeverages.Add(s4);
            coffeeBeverages.Add(s5);
            // Sort the items using the default comparer. 
            // For objects of type String, the default comparer sorts the items alphabetically.
            coffeeBeverages.Sort();
            // Write the collection to a console window.
            foreach (String coffeeBeverage in coffeeBeverages)
            {
                Console.WriteLine(coffeeBeverage);
            }    
        }

        public void UsingTheDictionaryClass(){
            // Using the Dictionary<TKey, TValue> Class
            // Create a new dictionary of strings with string keys.
            var coffeeCodes = new Dictionary<String, String>();
            // Add some entries to the dictionary.
            coffeeCodes.Add("CAL", "Café Au Lait");
            coffeeCodes.Add("CSM", "Cinammon Spice Mocha");
            coffeeCodes.Add("ER", "Espresso Romano");
            coffeeCodes.Add("RM", "Raspberry Mocha");
            coffeeCodes.Add("IC", "Iced Coffee");
            // This statement would result in an ArgumentException because the key already exists.
            // coffeeCodes.Add("IC", "Instant Coffee");
            // To retrieve the value associated with a key, you can use the indexer.
            // This will throw a KeyNotFoundException if the key does not exist.
            Console.WriteLine("The value associated with the key \"CAL\" is {0}", coffeeCodes["CAL"]);
            // Alternatively, you can use the TryGetValue method.
            // This returns true if the key exists and false if the key does not exist.
            string csmValue = "";
            if (coffeeCodes.TryGetValue("CSM", out csmValue))
            {
                Console.WriteLine("The value associated with the key \"CSM\" is {0}", csmValue);
            }
            else
            {
                Console.WriteLine("The key \"CSM\" was not found");
            }
            // You can also use the indexer to change the value associated with a key.
            coffeeCodes["IC"] = "Instant Coffee";
        }

        public struct Tea
        {
            public int Strength;
            public string Name;
        }
    }

    // Creating a Generic Class
    public class CustomList<T>
    {
        public T this[int index] { get { return this[index]; } set { this[index] = value; } }
        public void Add(T item)
        {
            // Method logic goes here.
        }
        public void Remove(T item)
        {
            // Method logic goes here.
        }
    }
  
}
