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
    
    public partial class Gender
    {
        public Gender()
        {
            this.Users = new HashSet<User>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<User> Users { get; set; }
    }
}
