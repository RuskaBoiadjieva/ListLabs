using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

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
                    case "swap":
                        Swap(int.Parse(command[1]), int.Parse(command[2]), numbers);
                        break;
                    case "multiply":
                        Multiply(int.Parse(command[1]), int.Parse(command[2]), numbers);
                        break;
                    case "decrease":
                        decrease(numbers);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void decrease(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }

        }

        private static void Multiply(int index1, int index2, List<int> numbers)
        {
            
            numbers[index1] = numbers[index1]*numbers[index2];
           
        }

        private static void Swap(int index1, int index2, List<int> numbers)
        {
            int currentNum = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = currentNum;

        }
    }
}
