using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
   public class CoverProcessor
    {
        public void Process(string path, Action<Book> coverHandler)
        {
            var book = Book.Load(path);

            coverHandler(book);

                book.Save();
        }
    }
}
