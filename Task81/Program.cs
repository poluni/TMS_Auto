using System.Collections;

namespace Task81
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList? biblioteque = new ArrayList();
            Book book1 = new Book("Пушкин А.С.", "Капитанская дочка", "1837");
            Book book2 = new Book("Остин Джейн", "Гордость и предубеждение", "1826");
            Library.AddBook(ref biblioteque, book1);
            Library.AddBook(ref biblioteque, book2);
            Console.WriteLine("Начальный список:");
            Library.PrintBooks(biblioteque);

            string searchAuthor = "Остин Джейн";
            Console.WriteLine("Найдено:");
            Library.SearchByAuthor(biblioteque, searchAuthor);

            Library.DeleteBook(ref biblioteque, book1);

            Console.WriteLine("Конечный список:");
            Library.PrintBooks(biblioteque);

            Library.Exit();
        }
    }
}
