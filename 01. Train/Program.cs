using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passangersInWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxPassangers = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> input = command.Split().ToList();
                if (input.Count == 2)
                {
                    passangersInWagons.Add(int.Parse(input[1]));
                }
                else if (input.Count == 1)
                {
                    for(int i=0; i<passangersInWagons.Count; i++)
                    {
                        
                        if (passangersInWagons[i] + int.Parse(input[0]) <= maxPassangers)
                        {
                            passangersInWagons[i]+=int.Parse(input[0]);
                          
                            break;
                        }
                    }
                }


                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', passangersInWagons));


        }
    }
}
