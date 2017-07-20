using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Original
{
    public class BookShelf : IAggregate
    {
        private readonly List<Book> _books = new List<Book>();

        public int Length => _books.Count;

        public void AppendBook(Book book)
        {
            _books.Add(book);
        }

        public Book GetBookAt(int index)
        {
            return _books[index];
        }

        public IIterator GetIterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
