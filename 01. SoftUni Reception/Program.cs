using System;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstWorker = int.Parse(Console.ReadLine());
            int secondWorker = int.Parse(Console.ReadLine());
            int thirdWorker = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            if (students == 0)
            {
                Console.WriteLine("Time needed: 0h.");
                return;
            }
            double studentsPerHour = firstWorker + secondWorker + thirdWorker;

            if (studentsPerHour > students)
            {
                Console.WriteLine("Time needed: 1h.");
            }
            else
            {

                double finalTime = Math.Ceiling(students / studentsPerHour);
                if (finalTime >= 4)
                {
                    finalTime += Math.Floor(finalTime / 4);
                }
                Console.WriteLine($"Time needed: {finalTime}h.");
            }
        }
    }
}
