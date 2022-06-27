using System;

namespace _01._The_Biscuit_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biscuitPerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int competingFactory = int.Parse(Console.ReadLine());
            double totalBiscuits = 0;
            int day = 1;

            while (day <= 30)
            {
                if (day % 3 == 0)
                {
                    totalBiscuits += Math.Floor(0.75 * (workers * biscuitPerDay));
                }
                else
                {
                    totalBiscuits += workers * biscuitPerDay;

                }

                day++;
            }
            Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");
            if (totalBiscuits>competingFactory)
            {
                double persent = (totalBiscuits - competingFactory) / competingFactory * 100;
                Console.WriteLine($"You produce {persent:f2} percent more biscuits.");
            }
            else
            {
                double persent = (competingFactory-totalBiscuits) / competingFactory * 100;
                Console.WriteLine($"You produce {persent:f2} percent less biscuits.");
            }
        }
    }
}
