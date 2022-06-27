using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = Console.ReadLine();
            int countOfShootTargets = 0;

            while (input != "End")
            {
                int shoot = int.Parse(input);

                if (shoot < targets.Count && shoot >= 0 && targets[shoot] != -1)
                {
                    countOfShootTargets++;
                    int currentNum = targets[shoot];
                    targets.Insert(shoot, -1);
                    targets.RemoveAt(shoot + 1);

                    for (int i = 0; i < targets.Count; i++)
                    {
                        if (i != shoot && targets[i] <= currentNum && targets[i] != -1)
                        {
                            targets[i] = targets[i] + currentNum;
                        }
                        else if (i != shoot && targets[i] > currentNum && targets[i] != -1)
                        {
                            targets[i] = targets[i] - currentNum;
                        }

                    }
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {countOfShootTargets} -> {string.Join(' ', targets)}");
        }
    }
}
