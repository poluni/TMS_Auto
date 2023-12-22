namespace Task84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new("Пушкин А.С.", "Капитанская дочка", "45-3545");
            Book book2 = new("Достоевский Ф.М.", "Бесы", "4588-123");
            Book book3 = new("Пушкин А.С.", "Пиковая дама", "4555-878");
            Book book4 = new("Достоевский Ф.М.", "Идиот", "78-3452");
            Book book5 = new("Чехов А.П.", "Чайка", "112-4432");
            Library.AddBook(book1);
            Library.AddBook(book2);
            Library.AddBook(book3);
            Library.AddBook(book4);
            Library.AddBook(book5);

            Reader reader1 = new("Васильев А.А.", 45645688);
            Reader reader2 = new("Иванов П.Н.", 33453);
            Reader reader3 = new("Сидоров В.В.", 3873383);

            Library.PrintLibraryBooks();

            Library.CheckOutBook(reader1, book2);
            Library.CheckOutBook(reader1, book1);
            Library.CheckOutBook(reader2, book3);
            Library.CheckOutBook(reader1, book1);

            Console.WriteLine("После выдачи");
            Library.PrintLibraryBooks();
            Library.GivenBooksToReader();

            Library.ReturnBook(reader2, book3);
            Library.ReturnBook(reader2, book3);

            Console.WriteLine("После возврата");
            Library.PrintLibraryBooks();
            Library.GivenBooksToReader();
        }
    }
}
