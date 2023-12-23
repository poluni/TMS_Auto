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
            Helper.AddBook(ref biblioteque, book1);
            Helper.AddBook(ref biblioteque, book2);
            Console.WriteLine("Начальный список:");
            Helper.PrintBooks(biblioteque);

            string searchAuthor = "Остин Джейн";
            Console.WriteLine("Найдено:");
            Helper.SearchByAuthor(biblioteque, searchAuthor);

            Helper.DeleteBook(ref biblioteque, book1);

            Console.WriteLine("Конечный список:");
            Helper.PrintBooks(biblioteque);

            Helper.Exit();
        }
    }
}
