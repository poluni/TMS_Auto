using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task81
{
    internal class Book
    {
        public Book() { }

        public Book(string author, string title, string publicationYear)
        {
            Author = author;
            Title = title;
            PublicationYear = publicationYear;
        }

        public int ID { get; private set; } = new Random().Next();

        public string Title { get; set; }

        public string Author { get; set; }

        public string PublicationYear { get; set; }

        public static ArrayList DeleteBook(ref ArrayList? biblioteque, string searchAuthor, string searchTitle)
        {
            if (biblioteque.Count != 0)
            {
                foreach (var book in biblioteque.ToArray())
                {
                    if (book is Book item)
                    {
                        if (item.Author.Equals(searchAuthor) && item.Title.Equals(searchTitle))
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
