using _0311library.megjelenit;
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
        public object ujhozzaad(string title,int author,int year,int price)
        {
            using (var context = new konyvtardbContext())
            {
                var books = new ujhozzaad
                {
                    Title = title,
                    Author = author,
                    Year = year,
                    price = price,
                };
                context.Authors.Add(books);
                context.SaveChanges();
                return new { message = "Sikeres felvétel", result = books };
            }
        }
    }
}
