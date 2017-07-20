﻿using System.Collections;
using System.Collections.Generic;

namespace CSharpLike
{
    public class BookShelf
    {
        private readonly List<Book> _books = new List<Book>();

        public IEnumerable<Book> Enumerable
        {
            get
            {
                foreach (var book in _books)
                {
                    yield return book;
                }
            }
        }

        public void AppendBook(Book book)
        {
            _books.Add(book);
        }
    }
}
