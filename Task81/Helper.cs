using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task81
{
    internal class Helper
    {
        public static void Exit()
        {
            Console.Write("Для выхода из программы нажмите любую клавишу...");
            Console.ReadKey();
        }

        public static void AddBook(ref ArrayList? biblioteque, Book? book)
        {
            if (book is not null)
            {
                biblioteque.Add(book);
            }
        }

        public static ArrayList DeleteBook(ref ArrayList? biblioteque, Book book)
        {
            if (biblioteque.Count != 0)
            {
                foreach (var bookItem in biblioteque.ToArray())
                {
                    if (bookItem is Book item)
                    {
                        if (item.Equals(book))
                        {
                            biblioteque.Remove(book);
                        }
                    }
                }
            }
            return biblioteque;
        }

        public static void SearchByAuthor(ArrayList? biblioteque, string searchAuthor)
        {
            if (biblioteque.Count != 0)
            {
                foreach (var book in biblioteque)
                {
                    if (book is Book item)
                    {
                        if (item.Author.Equals(searchAuthor)) Console.WriteLine($"{item.ID.ToString()} {item.Author} {item.Title}");
                    }
                }
            }
        }

        public static void PrintBooks(IList biblioteque)
        {
            foreach (var book in biblioteque)
            {
                if (book is Book item)
                {
                    Console.WriteLine($"{item.ID.ToString()} {item.Author} {item.Title}");
                }
            }
            Console.WriteLine();
        }
    }
}
