namespace EMovi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Direct
    {
        public int DirectorID { get; set; }
        public int MovieID { get; set; }
        public string DirectorType { get; set; }
    
        public virtual Director Director { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
