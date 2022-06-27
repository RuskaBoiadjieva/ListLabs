using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> rowOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            while (true)
            {
                string input = Console.ReadLine();
                if (input=="end")
                {
                    break;
                }

                List<string> command = input.Split().ToList();
                switch (command[0])
                {
                    case "Delete":
                       
                            rowOfNumbers.RemoveAll(nums => nums == int.Parse(command[1]));
                       
                        break;
                    case "Insert":
                        rowOfNumbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }
            }
            Console.WriteLine(string.Join(' ', rowOfNumbers));

        }
    }
}
