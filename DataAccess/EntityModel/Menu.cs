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
    
    public partial class Menu
    {
        public Menu()
        {
            this.Menus1 = new HashSet<Menu>();
            this.Roles = new HashSet<Role>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public string Url { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string Description { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
    
        public virtual ICollection<Menu> Menus1 { get; set; }
        public virtual Menu Menu1 { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
