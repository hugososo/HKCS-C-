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
    
    public partial class salesrecord
    {
        public string staffID { get; set; }
        public string productID { get; set; }
        public decimal unitPrice { get; set; }
        public int soldQuantity { get; set; }
        public decimal commissionAmount { get; set; }
        public System.DateTime salesDate { get; set; }
    
        public virtual product product { get; set; }
        public virtual staff staff { get; set; }
    }
}
