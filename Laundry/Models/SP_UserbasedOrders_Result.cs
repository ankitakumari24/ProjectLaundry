//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laundry.Models
{
    using System;
    
    public partial class SP_UserbasedOrders_Result
    {
        public int Order_ID { get; set; }
        public string Service_Type { get; set; }
        public string UserName { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public string PickUp { get; set; }
        public string Order_Status { get; set; }
    }
}