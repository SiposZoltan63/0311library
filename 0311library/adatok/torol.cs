using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0311library.modelek;


namespace _0311library.adatok
{
    internal class torol
    {
        public object DeleteBook(int id)
        {
            konyvtarResults results = new konyvtarResults();
            using (var context = new konyvtardbContext())
            {
                var book = context.Books.Find(id);

                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    results.Message = "Törölve";
                    results.Result = book;
                    return results;
                }
                results.Message = "Nincs törölve";
                results.Result = book;
                return results;
            }
        }
    }
}
