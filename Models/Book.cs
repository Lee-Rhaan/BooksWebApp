using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksWebApp.Models
{
    public class Book
    {

        public int Id { get; set; }
        public string BookName { get; set; }
        public string BookText { get; set; }

        public Book()
        {

        }
    }
}
