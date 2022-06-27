using System;
using System.Collections.Generic;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
            numbers.ForEach(num => Console.Write(num + ", "));


            string[] cities = new string[3] { "Mumbai", "London", "New York" };
            var popularCities = new List<string>();
            popularCities.AddRange(cities);

            var numbers = new List<int>() { 10, 20, 30, 40 };
            numbers.Insert(1, 11);// inserts 11 at 1st index: after 10.

            foreach (var num in numbers)
                Console.Write(num);


            numbers.Remove(10); // removes the first 10 from a list
            numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

            var numbers = new List<int>() { 10, 20, 30, 40 };
            numbers.Contains(10); // returns true

            //The RemoveRange method removes a list of items from the starting index to the number of items.The following code snippet removes two items starting at 3rd position.
              authors.RemoveRange(3, 2);

            // Remove all items
            authors.Clear();

        }
    }
}
