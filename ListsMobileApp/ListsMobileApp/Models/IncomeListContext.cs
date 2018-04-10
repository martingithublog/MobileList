using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ListsMobileApp.Models
{
    [MetadataType(typeof(ExpensesMetaData))]
    public partial class Expenses
    {
    }
    public class ExpensesMetaData
    {
        [Display(Name = "Description")]
        public string ExpenseReason { get; set; }

        [Display(Name = "Amount")]
        public Nullable<decimal> ExpenseAmount { get; set; }
    }



    [MetadataType(typeof(IncomeMetaData))]
    public partial class Income
    {
    }
    public class IncomeMetaData
    {
       
        [Display(Name = "Description")]
        public string IncomeSorce { get; set;}

        [Display(Name = "Amount")]
        public int IncomeAmount { get; set; }
    }
}
