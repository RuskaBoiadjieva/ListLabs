using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double receipt = 0;
            string input = Console.ReadLine();
            while (input != "regular" && input != "special")
            {
                if (double.Parse(input) < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }
               
                receipt += double.Parse(input);
                input = Console.ReadLine();
            }
            if (receipt == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: { receipt:f2}$");
            Console.WriteLine($"Taxes: { receipt * 0.20:f2}$");
            
            receipt += receipt * 0.2;
            if (input == "special")
            {
                receipt -= receipt * 0.1;
            }
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {receipt:f2}$");
        }
    }
}
