using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLIDPrinciple
{
    public class BookStore
    {
        public static int _lastId = 0;
        private static List<Book> _books; //Only one list no matter how many instances.
        public static int NextId => ++_lastId;
        static BookStore()
        {
            _books = new List<Book>
            {
                new Book
                {
                    Id = NextId,
                    Title = "Some cool computer Science Book"
                }
        };
        }
        //You create IEnumerable so that the _books can't be modified. That is a new book cannot be added or deleted from the list. But the Book refernce can be modified.
        public IEnumerable<Book> Books => _books;

        /// <summary>
        /// Save Method is split into Create and replace methods 
        /// </summary>
        /// <param name="book"></param>
       /* public void Save(Book book)
        {
            if(_books.Any(p=>p.Id == book.Id))
            {
                //Find Index -- N
                var index = _books.FindIndex(p => p.Id == book.Id);
                _books[index] = book;
            }
            else
            {
                _books.Add(book);
            }
        }*/

        
        public void Create(Book book)
        {
            if (book.Id != default(int))
            {
                throw new Exception("ID is auto generated");
            }
            book.Id = NextId;
            _books.Add(book);
        }

        public void Replace(Book book)
        {
            if(!_books.Any(p => p.Id == book.Id))
            {
                throw new Exception($"Book {book.Id} not present");
            }
            var index = _books.FindIndex(p => p.Id == book.Id);
            _books[index] = book;
        }
        public Book Load(int bookId)
        {
            return _books.FirstOrDefault(p => p.Id == bookId);
        }
    }
}
