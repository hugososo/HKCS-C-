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
    
    public partial class product
    {
        public product()
        {
            this.orderitems = new HashSet<orderitem>();
            this.salesrecords = new HashSet<salesrecord>();
        }
    
        public string productID { get; set; }
        public string productName { get; set; }
        public long showcaseID { get; set; }
        public decimal unitPrice { get; set; }
        public int stockQuantity { get; set; }
        public Nullable<decimal> discount { get; set; }
        public byte[] image { get; set; }
        public string remark { get; set; }
    
        public virtual ICollection<orderitem> orderitems { get; set; }
        public virtual ICollection<salesrecord> salesrecords { get; set; }
        public virtual showcase showcase { get; set; }
    }
}
