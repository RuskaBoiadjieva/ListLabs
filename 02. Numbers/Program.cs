using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceOfNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input!="Finish")
            {
                List<string> command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (command[0])
                {
                    case "Add":
                        Add(int.Parse(command[1]), sequenceOfNumbers);
                        break;
                    case "Remove":
                        Remove(int.Parse(command[1]), sequenceOfNumbers);
                        break;
                    case "Replace":
                        Replace(int.Parse(command[1]), int.Parse(command[2]), sequenceOfNumbers);
                        break;
                    case "Collapse":
                        Collapse(int.Parse(command[1]), sequenceOfNumbers);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', sequenceOfNumbers));


        }

        private static void Collapse(int value, List<int> sequenceOfNumbers)
        {
            sequenceOfNumbers.RemoveAll(number => number < value);
        }

        private static void Replace(int value, int replacement, List<int> sequenceOfNumbers)
        {
            if (sequenceOfNumbers.Contains(value))
            {
                int index = sequenceOfNumbers.IndexOf(value);
                sequenceOfNumbers.Insert(index, replacement);
                sequenceOfNumbers.RemoveAt(index + 1);
            }
            
        }

        private static void Remove(int value, List<int> sequenceOfNumbers)
        {
            sequenceOfNumbers.Remove(value);
        }

        private static void Add(int value, List<int> sequenceOfNumbers)
        {
            sequenceOfNumbers.Add(value);
        }
    }
}
