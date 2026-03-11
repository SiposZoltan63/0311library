using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0311library.adatok
{
    internal class hozzaadas
    {
        public object CreateAuthor(string name)
        {
            using (var context = new konyvtardbContext())
            {
                var books = new Books
                {
                    AuthorName = name
                };
                context.Authors.Add(books);
                context.SaveChanges();
                return new { message = "Sikeres felvétel", result = books };
            }
        }
    }
}
