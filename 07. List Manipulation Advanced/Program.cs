using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            bool isManipulated = false;

            while (input != "end")
            {
                List<string> commands = input.Split().ToList();
                if (commands[0] == "Add")
                {
                    numbers.Add(int.Parse(commands[1]));
                    isManipulated = true;
                }
                else if (commands[0] == "Remove")
                {
                    numbers.Remove(int.Parse(commands[1]));
                    isManipulated = true;
                }
                else if (commands[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(commands[1]));
                    isManipulated = true;
                }
                else if (commands[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                    isManipulated = true;
                }
                else if (commands[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(commands[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (commands[0] == "PrintEven")
                {
                    PrintEvenNumbers(numbers);
                }
                else if (commands[0] == "PrintOdd")
                {
                    PrintOddNumbers(numbers);
                }
                else if (commands[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (commands[0] == "Filter")
                {
                    FilterNumbers(commands[1], int.Parse(commands[2]), numbers);
                    Console.WriteLine();
                }
                input = Console.ReadLine();
            }
            if (isManipulated)
            {
                Console.WriteLine(string.Join(' ', numbers));

            }
        }

        static void FilterNumbers(string opperand, int num, List<int> numbers)
        {

            foreach (var item in numbers)
            {
                switch (opperand)
                {
                    case ">":
                        if (item > num)
                        {
                            Console.Write($"{item} ");
                        }
                        break;
                    case ">=":
                        if (item >= num)
                        {
                            Console.Write($"{item} ");
                        }
                        break;
                    case "<":
                        if (item < num)
                        {
                            Console.Write($"{item} ");
                        }
                        break;
                    case "<=":
                        if (item <= num)
                        {
                            Console.Write($"{item} ");
                        }
                        break;
                }

            }
        }

        static void PrintEvenNumbers(List<int> numbers)
        {
            List<int> evenList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenList.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(' ', evenList));
        }
        static void PrintOddNumbers(List<int> numbers)
        {
            List<int> oddList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddList.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(' ', oddList));
        }
    }
}
