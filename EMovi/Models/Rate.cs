namespace EMovi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rate
    {
        public int MovieID { get; set; }
        public int Rating { get; set; }
        public int RatingID { get; set; }
    
        public virtual Movie Movie { get; set; }
    }
}
