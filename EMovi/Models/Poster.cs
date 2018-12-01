namespace EMovi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Poster
    {
        public int MovieID { get; set; }
        public string PosterLink { get; set; }
    
        public virtual Movie Movie { get; set; }
    }
}
