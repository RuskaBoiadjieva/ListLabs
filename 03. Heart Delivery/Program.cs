using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine().Split('@').Select(int.Parse).ToList();
            string input;
            int currentIndex = 0;

            while ((input = Console.ReadLine()) != "Love!")
            {
                List<string> command = input.Split().ToList();
                int jump = int.Parse(command[1]);

                if (currentIndex + jump >= neighborhood.Count)
                {
                    currentIndex = 0;
                    if (neighborhood[currentIndex] <= 0)
                    {
                        Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                        continue;
                    }
                    neighborhood[currentIndex] -= 2;
                    if (neighborhood[currentIndex] <= 0) Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    continue; ;
                }

                currentIndex += jump;

                if (neighborhood[currentIndex] <= 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                    continue;
                }
                neighborhood[currentIndex] -= 2;
                if (neighborhood[currentIndex] <= 0) Console.WriteLine($"Place {currentIndex} has Valentine's day.");

            }
            Console.WriteLine($"Cupid's last position was {currentIndex}.");
            Console.WriteLine(neighborhood.Any(x => x > 0) ?
                $"Cupid has failed {neighborhood.Where(x => x > 0).Count()} places." :
                $"Mission was successful.");
        }
    }
}
