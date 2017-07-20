using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Original
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookShelf = new BookShelf();
            bookShelf.AppendBook(new Book { Name = "Around the World in 80 Days" });
            bookShelf.AppendBook(new Book { Name = "Bible" });
            bookShelf.AppendBook(new Book { Name = "Cinderella" });
            bookShelf.AppendBook(new Book { Name = "Daddy-Long-Legs" });
            var iterator = bookShelf.GetIterator();
            while (iterator.HasNext)
            {
                var book = (Book)iterator.Next();
                Console.WriteLine(book.Name);
            }
            Console.ReadLine();
        }
    }
}
