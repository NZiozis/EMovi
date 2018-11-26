using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMovi.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime RelaseDate { get; set; }
        public ICollection<Rates> Ratings { get; set; }
    }
}