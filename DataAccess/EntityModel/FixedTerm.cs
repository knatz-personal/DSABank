//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class FixedTerm
    {
        public FixedTerm()
        {
            this.FixedTermAccounts = new HashSet<FixedTermAccount>();
        }
    
        public int ID { get; set; }
        public string Duration { get; set; }
    
        public virtual ICollection<FixedTermAccount> FixedTermAccounts { get; set; }
    }
}
