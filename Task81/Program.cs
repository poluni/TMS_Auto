using System.Collections;

namespace Task81
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Пушкин А.С.", "Капитанская дочка", "1837");
            Book book2 = new Book("Остин Джейн", "Гордость и предубеждение", "1826");
            Library.AddBook(book1);
            Library.AddBook(book2);
            Console.WriteLine("Начальный список:");
            Library.PrintBooks();

            string searchAuthor = "Остин Джейн";
            Console.WriteLine("Найдено:");
            Library.SearchByAuthor(searchAuthor);

            Library.DeleteBook(book1);

            Console.WriteLine("Конечный список:");
            Library.PrintBooks();

            Library.Exit();
        }
    }
}
