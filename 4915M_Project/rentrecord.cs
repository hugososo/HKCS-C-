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
    
    public partial class rentrecord
    {
        public long rentID { get; set; }
        public string tenantID { get; set; }
        public long showcaseID { get; set; }
        public decimal rentprice { get; set; }
        public string startday { get; set; }
        public int duration { get; set; }
        public System.DateTime endday { get; set; }
    
        public virtual showcase showcase { get; set; }
        public virtual tenant tenant { get; set; }
    }
}
