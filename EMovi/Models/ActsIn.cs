//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMovi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActsIn
    {
        public int MovieID { get; set; }
        public int ActorID { get; set; }
        public string CharacterName { get; set; }
    
        public virtual Actor Actor { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
