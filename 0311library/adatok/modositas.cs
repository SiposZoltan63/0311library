using System;
using _0311library.adatok;
using _0311library.modelek;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0311library.adatok
{
    internal class modositas
    {
        konyvtarResults konyvtarResults = new konyvtarResults();
        public object UpdateBook(int id, Books book)
        {
            using (var context = new konyvtardbContext())
            {
                var extendedBook = context.Books.Find(id);
                if (extendedBook != null)
                {
                    extendedBook.Title = book.Title;
                    context.Books.Update(extendedBook);
                    context.SaveChanges();
                    konyvtarResults.Message = "Sikeres módosítás.";
                    konyvtarResults.Result = extendedBook;
                    return konyvtarResults;
                }
                konyvtarResults.Message = "Sikertelen módosítás.";
                konyvtarResults.Result = extendedBook;
                return konyvtarResults;
            }
        }
    }
}
