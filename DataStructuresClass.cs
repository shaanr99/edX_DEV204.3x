/****************************** Module Header ******************************\
Module Name:  DataStructuresClass.cs
Project:      edX_DEV204.3x
Copyright (c) Shaan Foltz

DataStructuresClass - examples of different types of data structures. 


THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/
using System;
namespace edX_DEV204
{
    public class DataStructuresClass
    {
        // Arrays are also data structures, but they 
        // are covered in their own class called
        // ArraysClass.

        public DataStructuresClass()
        {
        }

        enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        enum DayStartAtOne { Sunday = 4, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        struct Address {
            public int Number;
            public string Street;
            public string City;
            public string State;
            public int ZipCode;
        }

        public struct Coffee
        {
            // This is the custom constructor.
            public Coffee(int strength, string bean, string countryOfOrigin){
                Strength = strength;
                Bean = bean;
                CountryOfOrigin = countryOfOrigin;
            }

            // These statements declare the struct fields and set the default values.
            public int Strength;
            public string Bean;
            public string CountryOfOrigin;
            // Other methods, fields, properties, and events.
        }

        public void PlayWithEnumerations(){
            // Set an enum variable by name.
            Day favoriteDay = Day.Friday;
            Console.WriteLine("Set an enum by variable name (Day favoriteDay = Day.Friday): " + favoriteDay.ToString());

            // Set an enum variable by value.
            favoriteDay = (Day)4;
            Console.WriteLine("Set an enum by variable value (favoriteDay = (Day)4): " + (int)favoriteDay);

            // Changing the start index of an enum
            DayStartAtOne dayStartAtOne = DayStartAtOne.Friday;
            Console.WriteLine("Friday was at index = " + (int)favoriteDay);
            Console.WriteLine("Friday is now at index = " + (int)dayStartAtOne);

        }

        public void PlayWithStructs(){

            // instantiate an address struct
            Address address = new Address();
            address.City = "Nashua";
            address.State = "NH";

            Console.WriteLine("address.City = " + address.City);
            Console.WriteLine("address.State = " + address.State);


        }

    }
}
