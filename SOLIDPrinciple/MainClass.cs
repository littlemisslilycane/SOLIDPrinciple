using System;
namespace SOLIDPrinciple
{
    class MainClass
    {
        public static void Main()
        {
            //BookStore is not the best example for Single Responsibility IMHO.            
            Book book = new Book { Title = "Harry Potter and the Philosopher's stone" };
            BookStore store = new BookStore();
            store.Create(book);
            BookStore store2 = new BookStore();
            Console.WriteLine("That's all folks!");

        }
    }
}
