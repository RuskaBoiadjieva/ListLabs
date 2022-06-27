using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "End")
            {
                List<string> commands = input.Split().ToList();

                switch (commands[0])
                {
                    case "Add":
                        listOfNumbers.Add(int.Parse(commands[1]));
                        break;

                    case "Insert":
                        if (int.Parse(commands[2]) >= listOfNumbers.Count || int.Parse(commands[2]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        else
                        {
                            listOfNumbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));

                        }
                        break;
                    case "Remove":
                        if (int.Parse(commands[1]) >= listOfNumbers.Count || int.Parse(commands[2]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        else
                        {

                        listOfNumbers.RemoveAt(int.Parse(commands[1]));
                        }
                        break;
                    case "Shift":
                        switch (commands[1])
                        {
                            case "left":
                                int countLeft = int.Parse(commands[2]);
                                MoveListLeft(listOfNumbers, countLeft);
                                break;
                            case "right":
                                int countRight = int.Parse(commands[2]);
                                MoveListRight(listOfNumbers, countRight);
                                break;
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', listOfNumbers));
        }

        static void MoveListRight(List<int> listOfNumbers, int countRight)
        {
            for (int i = 0; i < countRight; i++)
            {
                listOfNumbers.Insert(0, listOfNumbers[listOfNumbers.Count - 1]);
                listOfNumbers.RemoveAt(listOfNumbers.Count - 1);
            }
            //for (int i = 0; i < countRight; i++)
            //{
            //    int currentNum = listOfNumbers[listOfNumbers.Count - 1];

            //    for (int j = listOfNumbers.Count - 1; j > 0; j--)
            //    {

            //        listOfNumbers[j] = listOfNumbers[j - 1];
            //    }

            //    listOfNumbers[0] = currentNum;
            //}
        }

        static void MoveListLeft(List<int> listOfNumbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                listOfNumbers.Add(listOfNumbers[0]);
                listOfNumbers.RemoveAt(0);
            }
            //for (int i = 0; i < count; i++)
            //{
            //    int currentNum = listOfNumbers[0];

            //    for (int j = 0; j < listOfNumbers.Count - 1; j++)
            //    {

            //        listOfNumbers[j] = listOfNumbers[j + 1];
            //    }

            //    listOfNumbers[listOfNumbers.Count - 1] = currentNum;
            //}
        }
    }
}
