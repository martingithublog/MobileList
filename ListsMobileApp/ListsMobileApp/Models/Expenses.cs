//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListsMobileApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Expenses
    {
        public int IDExpenses { get; set; }
        public string ExpenseReason { get; set; }
        public Nullable<decimal> ExpenseAmount { get; set; }
        public Nullable<System.DateTime> ExpenseDate { get; set; }
    }
}
