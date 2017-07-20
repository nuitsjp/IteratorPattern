using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Original
{
    public class BookShelfIterator : IIterator
    {
        private readonly BookShelf _bookShelf;

        private int index = 0;

        public BookShelfIterator(BookShelf bookShelf)
        {
            _bookShelf = bookShelf;
        }

        public bool HasNext
        {
            get { return index < _bookShelf.Length; }
        }

        public object Next()
        {
            var book = _bookShelf.GetBookAt(index);
            index++;
            return book;
        }
    }
}
