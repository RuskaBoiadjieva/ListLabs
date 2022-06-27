using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "End")
            {
                List<string> command = input.Split().ToList();

                switch (command[0])
                {
                    case "Shoot":
                        Shoot(int.Parse(command[1]), int.Parse(command[2]), targets);
                        break;
                    case "Add":
                        Add(int.Parse(command[1]), int.Parse(command[2]), targets);
                        break;
                    case "Strike":
                        Strike(int.Parse(command[1]), int.Parse(command[2]), targets);
                        break;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join('|', targets));

        }

        private static void Strike(int index, int radius, List<int> targets)
        {
            //Remove the target at the given index and the ones before and after it depending on the radius.
            //If any of the indices in the range is invalid, print: "Strike missed!" and skip this command.
            if (index > targets.Count - 1 || index < 0 || index - radius < 0 || index + radius > targets.Count - 1)
            {
                Console.WriteLine("Strike missed!");
                return;
            }
            else
            {
                targets.RemoveRange(index - radius, radius * 2 + 1);

            }

        }

        private static void Add(int index, int value, List<int> targets)
        {
            //Insert a target with the received value at the received index if it exists.
            //If not, print: "Invalid placement!"
            if (index < targets.Count && index >= 0)
            {
                targets.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }

        }

        private static void Shoot(int index, int power, List<int> targets)
        {
            if (index < targets.Count && index >= 0)
            {
                targets[index] -= power;
                if (targets[index] <= 0)
                {
                    targets.RemoveAt(index);
                }
            }
            //Shoot the target at the index if it exists by reducing its value by the given power (integer value). 
            //Remove the target if it is shot. A target is considered shot when its value reaches 0.

        }
    }
}
