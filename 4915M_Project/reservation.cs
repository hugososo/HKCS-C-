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
    
    public partial class reservation
    {
        public long showcaseID { get; set; }
        public string customerID { get; set; }
        public System.DateTime queueDate { get; set; }
        public int duration { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual showcase showcase { get; set; }
    }
}
