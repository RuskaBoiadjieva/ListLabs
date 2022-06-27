using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //•	merge { startIndex} { endIndex}
            //If any of the given indexes is out of the array, you must take only the range that is inside the array and merge it.
            //•	divide { index}   { partitions}

            List<string> array = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();

            while (input!="3:1")
            {
                List<string> command = input.Split().ToList();
                if (command[0]=="merge")
                {
                    MergeArray(int.Parse(command[1]),int.Parse(command[2]), array);
                    Console.WriteLine(string.Join(' ', array));
                }
                if (command[0]=="divide")
                {

                }
                input = Console.ReadLine();
            }

        }

        static List<string>  MergeArray(int command1,int command2, List<string> array)
        {
            for (int i = Math.Max(command1,0); i < Math.Min(command2,array.Count-1)-1; i++)
            {
                array[i]=array[i]. ;

            }
            return array;
        }
    }
}
