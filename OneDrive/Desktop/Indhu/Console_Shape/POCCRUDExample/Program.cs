using System;
using System.Collections.Generic;

namespace POCCRUDExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            Console.WriteLine("List CRUD Operations");
            List<string> list = new List<string>();

            // Create
            list.Add("Apple");
            list.Add("Banana");
            list.Add("Mango");

            // Read
            Console.WriteLine("List Items:");
            foreach (var item in list)
                Console.WriteLine(item);

            // Update
            list[2] = "Orange";

            // Delete
            list.Remove("Apple");

            Console.WriteLine("After Update & Delete:");
            foreach (var item in list)
                Console.WriteLine(item);

            Console.WriteLine("\n----------------------");

            //Set
            Console.WriteLine("Set CRUD Operations");
            HashSet<int> set = new HashSet<int>();

            // Create
            set.Add(10);
            set.Add(20);
            set.Add(30);

            // Read
            Console.WriteLine("Set Items:");
            foreach (var item in set)
                Console.WriteLine(item);

            // Update 
            set.Remove(20);
            set.Add(25);

            // Delete
            set.Remove(30);

            Console.WriteLine("After Update & Delete:");
            foreach (var item in set)
                Console.WriteLine(item);

            Console.WriteLine("\n----------------------");

            //Dictionary
            Console.WriteLine("DICTIONARY CRUD OPERATIONS");
            Dictionary<int, string> dict = new Dictionary<int, string>();

            // Create
            dict.Add(1, "Varun");
            dict.Add(2, "Nikhil");
            dict.Add(3, "Gowtham");

            // Read
            Console.WriteLine("Dictionary Items:");
            foreach (var item in dict)
                Console.WriteLine(item.Key + " : " + item.Value);

            // Update
            dict[2] = "Devansh";

            // Delete
            dict.Remove(3);

            Console.WriteLine("After Update & Delete:");
            foreach (var item in dict)
                Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}
