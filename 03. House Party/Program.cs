using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            
            List<string> names = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> commands = Console.ReadLine().Split().ToList();

                if (!names.Contains(commands[0]) && commands[2] == "going!")
                {
                    names.Add(commands[0]);
                }
                else if (names.Contains(commands[0]) && commands[2] == "going!")
                {
                    Console.WriteLine($"{commands[0]} is already in the list!");
                }
                else if (names.Contains(commands[0]) && commands[2] == "not")
                {
                    names.Remove(commands[0]);
                }
                else if (!names.Contains(commands[0]) && commands[2] == "not")
                {
                    Console.WriteLine($"{commands[0]} is not in the list!");
                }
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
