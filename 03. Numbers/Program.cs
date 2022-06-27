using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newArray = new List<int>();

            double averageValue = numbers.Average();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageValue)
                {

                    newArray.Add(numbers[i]);


                }
            }
            if (newArray.Count < 1)
            {
                Console.WriteLine("No");
                return;
            }
            newArray.Sort();
            newArray.Reverse();
            if (newArray.Count >= 5)
            {

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{newArray[i]} ");
                }
            }
            else
            {
                Console.WriteLine(String.Join(' ', newArray));
            }

        }
    }
}
