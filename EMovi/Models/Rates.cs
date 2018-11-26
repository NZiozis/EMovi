using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMovi.Models
{
    public class Rates
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public int Rating { get; set; }
    }
}