namespace EMovi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Image
    {
        public int PersonID { get; set; }
        public string ImageLink { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
