using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple
{
    class BookPresenter
    {
        public void DisplayBook(Book book)
        {
            Console.WriteLine($"Book: {book.Title} ({book.Id})");
        }
    }
}
