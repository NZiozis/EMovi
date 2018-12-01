namespace EMovi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Actor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actor()
        {
            this.ActsIns = new HashSet<ActsIn>();
        }
    
        public int ActorId { get; set; }
        public int PersonID { get; set; }
    
        public virtual Person Person { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActsIn> ActsIns { get; set; }
    }
}
