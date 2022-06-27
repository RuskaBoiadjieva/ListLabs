using System;
using System.Linq;

namespace Problem_2___The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            var statusOfLift = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxCapacity = statusOfLift.Length * 4 - statusOfLift.Sum();

            while (waitingPeople > 0 && maxCapacity > 0)
            {
                int freeSeat = 0;
                for (int i = 0; i < statusOfLift.Length; i++)
                {

                    if (statusOfLift[i] < 4)
                    {
                        freeSeat = 4 - statusOfLift[i];
                        if (waitingPeople>freeSeat)
                        {
                        statusOfLift[i] += freeSeat;
                        waitingPeople -= freeSeat;
                        maxCapacity -= freeSeat;

                        }
                        else
                        {
                            statusOfLift[i] += waitingPeople;
                            maxCapacity -= waitingPeople;
                            waitingPeople -= waitingPeople;
                        }
                    }
                }
            }
            if (waitingPeople == 0 && maxCapacity > 0)
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(string.Join(' ', statusOfLift));
            }
            if (waitingPeople > 0 && maxCapacity == 0)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                Console.WriteLine(string.Join(' ', statusOfLift));
            }
            if (maxCapacity==0&&waitingPeople==0)
            {
                Console.WriteLine(string.Join(' ', statusOfLift));
            }
        }
    }
}
