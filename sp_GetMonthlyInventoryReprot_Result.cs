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
    
    public partial class sp_GetMonthlyInventoryReprot_Result
    {
        public string CompanyName { get; set; }
        public Nullable<System.DateTime> InventoryDate { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string InvoiceNo { get; set; }
        public string IsPaid { get; set; }
        public string IsOnCredit { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
    }
}
