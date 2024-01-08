using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task84
{
    internal static class Library
    {
        public static List<Book> LibraryBooks { get; set; } = [];
        public static Dictionary<Reader, HashSet<Book>> IssuedBooks { get; set; } = [];

        public static void AddBook(Book book)
        {
            LibraryBooks.Add(book);
        }

        public static void CheckOutBook(Reader reader, Book book)
        {
            if (LibraryBooks.Remove(book))
            {
                if (!IssuedBooks.TryGetValue(reader, out var readerBooks))
                {
                    readerBooks = new HashSet<Book>();
                    IssuedBooks.Add(reader, readerBooks);
                }
                readerBooks.Add(book);
            }
            else
            {
                Console.WriteLine("Книга не найдена.");
            }
        }

        public static void ReturnBook(Reader reader, Book book)
        {
            HashSet<Book> booksSet;
            if (IssuedBooks.TryGetValue(reader, out booksSet))
            {
                foreach (var item in booksSet)
                {
                    if (item.Equals(book))
                    {
                        LibraryBooks.Add(book);
                        booksSet.Remove(item);
                    }
                }
            }
            else Console.WriteLine("Книга не найдена.");
        }

        public static void PrintLibraryBooks()
        {
            Console.WriteLine("Список книг в библиотеке");
            foreach (Book book in LibraryBooks)
            {
                Console.WriteLine($"Автор: {book.Author} Название: {book.Title} ISBN: {book.ISBN}");
            }
            Console.WriteLine();
        }

        public static void GivenBooksToReader()
        {
            Console.WriteLine("Список книг выданных читателям");
            foreach (var reader in IssuedBooks)
            {
                if (reader.Value.Count == 0) Console.Write("У читателя нет выданных книг.");
                else
                {
                    Console.WriteLine($"У читателя {reader.Key.Name} {reader.Key.LibraryCardNumber}: ");
                    if (reader.Value is HashSet<Book> book)
                        foreach (var item in book)
                            Console.WriteLine($"Автор: {item.Author} Название: {item.Title} ISBN: {item.ISBN}");
                }
            }
            Console.WriteLine();
        }
    }
}