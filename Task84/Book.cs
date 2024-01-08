using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task84
{
    internal class Book
    {
        public Book() { }

        public Book(string author, string title, string isbn)
        {
            Author = author;
            Title = title;
            ISBN = isbn;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        protected bool Equals(Book other)
        {
            return Author == other.Author
                && Title == other.Title
                && ISBN == other.ISBN;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Book)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Author, Title, ISBN);
        }
    }
}
