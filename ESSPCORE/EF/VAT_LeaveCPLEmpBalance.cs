//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESSPCORE.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class VAT_LeaveCPLEmpBalance
    {
        public int PCPLBalanceID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string OEmpID { get; set; }
        public string EmployeeName { get; set; }
        public Nullable<double> CPLBalance { get; set; }
        public Nullable<double> Used { get; set; }
        public Nullable<double> RemainingBalance { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public Nullable<bool> IsExpire { get; set; }
    }
}
