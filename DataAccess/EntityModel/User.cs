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
    
    public partial class User
    {
        public User()
        {
            this.Accounts = new HashSet<Account>();
            this.Appointments = new HashSet<Appointment>();
            this.Roles = new HashSet<Role>();
        }
    
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public Nullable<int> GenderID { get; set; }
        public string Email { get; set; }
        public int Mobile { get; set; }
        public string Address { get; set; }
        public Nullable<int> TownID { get; set; }
        public Nullable<int> TypeID { get; set; }
        public bool Blocked { get; set; }
        public int NoOfAttempts { get; set; }
    
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Town Town { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
