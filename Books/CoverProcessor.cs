using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
   public class CoverProcessor
    {
      //passing a delegate into method
        public void Process(string path, Action<Book> coverHandler)
        {
            var book = Book.Load(path);
            
           //client of this code will define what to use
            coverHandler(book);

                book.Save();
        }
    }
}
