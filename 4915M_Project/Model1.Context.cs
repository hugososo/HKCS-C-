﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<branch> branches { get; set; }
        public DbSet<buyorder> buyorders { get; set; }
        public DbSet<creditcard> creditcards { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<district> districts { get; set; }
        public DbSet<orderitem> orderitems { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<region> regions { get; set; }
        public DbSet<reservation> reservations { get; set; }
        public DbSet<salesrecord> salesrecords { get; set; }
        public DbSet<staff> staffs { get; set; }
        public DbSet<tenant> tenants { get; set; }
        public DbSet<showcase> showcases { get; set; }
        public DbSet<rentrecord> rentrecords { get; set; }
        public DbSet<bill> bills { get; set; }
    }
}