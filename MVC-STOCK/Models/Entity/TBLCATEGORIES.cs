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
    
    public partial class TBLCATEGORIES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLCATEGORIES()
        {
            this.TBLPRODUCTS = new HashSet<TBLPRODUCTS>();
        }
    
        public short CATEGORYID { get; set; }
        public string CATEGORYNAME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPRODUCTS> TBLPRODUCTS { get; set; }
    }
}
