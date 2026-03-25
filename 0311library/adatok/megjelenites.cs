using _0311library.modelek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using Microsoft.EntityFrameworkCore;


namespace _0311library.adatok
{
    public class megjelenites
    {
        public List<Books> ReadBooks()
        {

            using (var context = new konyvtardbContext())
            {
                var book = context.Books.ToList();
                return book;
            }
        }
    }
}
