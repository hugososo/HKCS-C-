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
    
    public partial class district
    {
        public int districtID { get; set; }
        public int regionID { get; set; }
        public string districtName { get; set; }
    
        public virtual region region { get; set; }
    }
}
