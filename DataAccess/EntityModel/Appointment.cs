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
    
    public partial class Appointment
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }
        public System.DateTime SuggestedDate { get; set; }
        public System.TimeSpan SuggestedTime { get; set; }
        public string Duration { get; set; }
        public Nullable<bool> IsAccepted { get; set; }
    
        public virtual User User { get; set; }
    }
}
