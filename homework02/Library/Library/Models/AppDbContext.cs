using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext():base("DefaultConnection") { }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }

        public DbSet<Book> Books { get; set; }
    }
}