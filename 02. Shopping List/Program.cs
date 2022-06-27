using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split('!').ToList();
            string input = Console.ReadLine();

            while (input!= "Go Shopping!")
            {
                List<string> commands = input.Split().ToList();
                switch (commands[0])
                {
                    case "Urgent":
                        Urgent(commands[1], shoppingList);
                        break;
                    case "Unnecessary":
                        Unnecessary(commands[1], shoppingList);
                        break;
                    case "Correct":
                        Correct(commands[1], commands[2], shoppingList);
                        break;
                    case "Rearrange":
                        Rearrange(commands[1], shoppingList);
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", shoppingList));
        }

        private static void Rearrange(string item, List<string> list)
        {
            if (list.Contains(item))
            {
                
                list.Remove(item);
                list.Add(item);
            }
        }

        private static void Correct(string oldItem, string newItem, List<string> list)
        {
            if (list.Contains(oldItem))
            {
                int index = list.IndexOf(oldItem);
                list.Insert(index, newItem);
                list.RemoveAt(index + 1);
            }
        }

        private static void Unnecessary(string item, List<string> list)
        {
            list.Remove(item);
        }

        private static void Urgent(string item, List<string> list)
        {
            //"Urgent {item}" - add the item at the start of the list.  If the item already exists, skip this command.
            if (!list.Contains(item))
            {
                list.Insert(0, item);
            }
        }
    }
}
