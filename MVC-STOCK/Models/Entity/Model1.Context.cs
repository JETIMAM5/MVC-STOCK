﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_STOCK.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MvcDbStockEntities : DbContext
    {
        public MvcDbStockEntities()
            : base("name=MvcDbStockEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLCATEGORIES> TBLCATEGORIES { get; set; }
        public virtual DbSet<TBLCUSTOMERS> TBLCUSTOMERS { get; set; }
        public virtual DbSet<TBLPRODUCTS> TBLPRODUCTS { get; set; }
        public virtual DbSet<TBLSALES> TBLSALES { get; set; }
    }
}
