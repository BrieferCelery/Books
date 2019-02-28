using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            var coverProcessor = new CoverProcessor();
            var covers = new BookCover();
            Action<Book> coverHandler = covers.AlternateCover;
            coverHandler += covers.InternationalCover;
            coverHandler += CrazyCover;

            coverProcessor.Process("Harry Potter", coverHandler);
            Console.ReadLine();

        }

        static void CrazyCover(Book book)
        {
            Console.WriteLine("crazy cover");
        }
    }
}
