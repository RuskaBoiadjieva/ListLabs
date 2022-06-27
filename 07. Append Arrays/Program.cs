using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Split('|').Reverse().ToList();
            List<int> newArr = new List<int>();
            foreach (var item in array)
            {
               newArr.AddRange(item.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            
            Console.WriteLine(string.Join(' ', newArr));

        }
    }
}
