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

        protected bool Equals(Book other)
        {
            return ID == other.ID
                && Author == other.Author
                && Title == other.Title
                && PublicationYear == other.PublicationYear;
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
            return HashCode.Combine(ID, Author, Title, PublicationYear);
        }
    }
}
