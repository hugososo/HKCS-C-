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
    
    public partial class customer
    {
        public customer()
        {
            this.buyorders = new HashSet<buyorder>();
            this.creditcards = new HashSet<creditcard>();
            this.reservations = new HashSet<reservation>();
        }
    
        public string customerID { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string emailAddress { get; set; }
        public string billingAddress { get; set; }
        public byte[] avatar { get; set; }
        public string telephone { get; set; }
    
        public virtual ICollection<buyorder> buyorders { get; set; }
        public virtual ICollection<creditcard> creditcards { get; set; }
        public virtual ICollection<reservation> reservations { get; set; }
    }
}
