using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookManagement.Models
{
    public class Model_Book_Context : DbContext
    {
        public Model_Book_Context() : base("BookManagement")
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}