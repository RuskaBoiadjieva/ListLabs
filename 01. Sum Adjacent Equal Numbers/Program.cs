using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<decimal> newLine = Console.ReadLine().Split().Select(decimal.Parse).ToList();
          

                for (int i = 0; i < newLine.Count - 1; i++)
                {
                    if (newLine[i] == newLine[i + 1])
                    {
                        decimal currentnum = newLine[i] + newLine[i + 1];
                        newLine.Remove(newLine[i]);
                        newLine.Remove(newLine[i]);
                        newLine.Insert(i, currentnum);
                        i = -1;
                    }
                }
               
            

            //for (int i = 0; i < newLine.Count - 1; i++)
            //{
            //    if (newLine[i] == newLine[i + 1])
            //    {
            //        newLine[i] += newLine[i + 1];
            //        newLine.RemoveAt(i + 1);
            //        i = -1;
            //    }
            //    Console.WriteLine(string.Join(' ', newLine));
            //}

            Console.WriteLine(string.Join(' ', newLine));

        }

    }

}
