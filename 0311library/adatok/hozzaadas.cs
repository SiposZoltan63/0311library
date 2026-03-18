using _0311library.modelek;
using Pomelo.EntityFrameworkCore.MySql.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _0311library.adatok
{
    internal class hozzaadas
    {
        public object CreateBooks(string title,string author,int year,int price)
        {
            using (var context = new konyvtardbContext())
            {
                var books = new Books
                {
                    Title = title,
                    Author = author,
                    Year = year,
                    Price = price,
                };
                context.Books.Add(books);
                context.SaveChanges();
                return new { message = "Sikeres felvétel", result = books };
            }
        }
    }
}
