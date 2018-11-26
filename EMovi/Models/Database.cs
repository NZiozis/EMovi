using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EMovi.Models
{
    public class Database : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rates> Ratings { get; set; }
    }
}