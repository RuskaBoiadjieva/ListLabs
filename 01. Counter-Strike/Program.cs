using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int winBattles = 0;

            while (initialEnergy >= 0 && input != "End of battle")
            {
                int distance = int.Parse(input);
                if (distance<=initialEnergy)
                {
                    initialEnergy -= distance;
                    winBattles++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winBattles} won battles and {initialEnergy} energy");
                    return;
                }
                if (winBattles%3==0)
                {
                    initialEnergy += winBattles;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {winBattles}. Energy left: {initialEnergy}");
        }
    }
}
