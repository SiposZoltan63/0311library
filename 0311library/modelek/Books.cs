using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0311library.modelek
{
    public partial class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int? Year { get; set; }
        public int? Price { get; set; }
    }
}
