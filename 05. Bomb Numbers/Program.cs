using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bomb= Console.ReadLine().Split().Select(int.Parse).ToList();

            
            for (int i = 0; i < numbers.Count; i++)

            {
                int start = Math.Max(0, i - bomb[1]);
                int end = Math.Min(bomb[1] + i, numbers.Count-1);
                if (numbers[i]==bomb[0])
                {
                    for (int j = start; j <= end; j++)
                    {
                        numbers[j]=0;
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
