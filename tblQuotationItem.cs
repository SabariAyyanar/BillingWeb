//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillingWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblQuotationItem
    {
        public int QuotationItemID { get; set; }
        public Nullable<int> QuotationID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string Make { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<int> UnitID { get; set; }
        public Nullable<int> SizeID { get; set; }
        public Nullable<decimal> RatePerUnit { get; set; }
        public Nullable<int> TaxID { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string Remark { get; set; }
        public Nullable<int> HSN_SAC { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<decimal> SGST { get; set; }
        public Nullable<decimal> CGST { get; set; }
    
        public virtual tblProduct tblProduct { get; set; }
        public virtual tblQuotation tblQuotation { get; set; }
        public virtual tblSize tblSize { get; set; }
        public virtual tblTax tblTax { get; set; }
        public virtual tblUnit tblUnit { get; set; }
    }
}
