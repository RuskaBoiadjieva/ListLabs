﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> booksShelf = Console.ReadLine().Split('&').ToList();
            string input = Console.ReadLine();

            while (input!="Done")
            {
                List<string> command = input.Split(" | ").ToList();

                switch (command[0])
                {
                    case "Add Book":
                        AddBook(command[1], booksShelf);
                        break;
                    case "Take Book":
                        TakeBook(command[1], booksShelf);
                        break;
                    case "Swap Books":
                        SwapBooks(command[1],command[2], booksShelf);
                        break;
                    case "Insert Book":
                        InsertBook(command[1], booksShelf);
                        break;
                    case "Check Book":
                        CheckBook(int.Parse(command[1]), booksShelf);
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", booksShelf));
        }

        private static void CheckBook(int index, List<string> booksShelf)
        {
            if (index>=0 && index<booksShelf.Count)
            {
                Console.WriteLine(booksShelf[index]);
            }
        }

        private static void InsertBook(string bookName, List<string> booksShelf)
        {
            if (!booksShelf.Contains(bookName))
            {
                booksShelf.Add(bookName);
            }
        }

        private static void SwapBooks(string book1, string book2, List<string> booksShelf)
        {
            if (booksShelf.Contains(book1)&& booksShelf.Contains(book2))
            {
                int index1 = booksShelf.IndexOf(book1);
                int index2 = booksShelf.IndexOf(book2);
                string currentBook = book1;
                booksShelf.Insert(index1, book2);
                booksShelf.RemoveAt(index1 + 1);
                booksShelf.Insert(index2, currentBook);
                booksShelf.RemoveAt(index2 + 1);
            }
        }

        private static void TakeBook(string bookName, List<string> booksShelf)
        {
            if (booksShelf.Contains(bookName))
            {
                booksShelf.Remove(bookName);
            }
        }

        private static void AddBook(string bookName, List<string> booksShelf)
        {
            if (!booksShelf.Contains(bookName))
            {
                booksShelf.Insert(0, bookName);
            }
        }
    }
}
