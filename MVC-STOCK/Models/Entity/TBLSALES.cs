//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class TBLSALES
    {
        public int SALEID { get; set; }
        public Nullable<int> PRODUCT { get; set; }
        public Nullable<int> CUSTOMER { get; set; }
        public Nullable<byte> AMOUNT { get; set; }
        public Nullable<decimal> PRICE { get; set; }
    
        public virtual TBLCUSTOMERS TBLCUSTOMERS { get; set; }
        public virtual TBLPRODUCTS TBLPRODUCTS { get; set; }
    }
}
