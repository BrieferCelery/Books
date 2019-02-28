using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class BookCover
    {
        public void PrimaryCover(Book book)
        {
            Console.WriteLine("Primary book cover");
        }

        public void AlternateCover(Book book)
        {
            Console.WriteLine("Alternate book cover");
        }

        public void InternationalCover(Book book)
        {
            Console.WriteLine("Int'l cover");
        }
    }
}
