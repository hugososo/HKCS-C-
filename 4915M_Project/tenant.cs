//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _4915M_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class tenant
    {
        public tenant()
        {
            this.showcases = new HashSet<showcase>();
            this.rentrecords = new HashSet<rentrecord>();
            this.bills = new HashSet<bill>();
        }
    
        public string tenantID { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string emailAddress { get; set; }
        public string billingAddress { get; set; }
        public string telephone { get; set; }
        public System.DateTime joinDate { get; set; }
        public byte[] avatar { get; set; }
    
        public virtual ICollection<showcase> showcases { get; set; }
        public virtual ICollection<rentrecord> rentrecords { get; set; }
        public virtual ICollection<bill> bills { get; set; }
    }
}
