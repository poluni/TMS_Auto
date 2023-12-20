using System.Collections;

namespace Task81
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList? biblioteque = new ArrayList();
            Book.AddBook(ref biblioteque, new Book("Пушкин А.С.", "Капитанская дочка", "1837"));
            Book.AddBook(ref biblioteque, new Book("Остин Джейн", "Гордость и предубеждение", "1826"));
            Console.WriteLine("Начальный список:");
            Book.PrintBooks(biblioteque);

            string searchAuthor = "Остин Джейн";
            Console.WriteLine("Найдено:");
            Book.SearchByAuthor(biblioteque, searchAuthor);

            string authorToDelete = "Пушкин А.С.";
            string titleToDelete = "Капитанская дочка";
            Book.DeleteBook(ref biblioteque, authorToDelete, titleToDelete);

            Console.WriteLine("Конечный список:");
            Book.PrintBooks(biblioteque);

            Helper.Exit();
        }
    }
}
