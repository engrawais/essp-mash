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
    
    public partial class OTApprovedHistory
    {
        public int POTApprovedOTHistoryID { get; set; }
        public Nullable<int> EmpID { get; set; }
        public Nullable<int> MonthDataID { get; set; }
        public Nullable<int> SubmittedToID { get; set; }
        public Nullable<int> SubmittedByID { get; set; }
        public string OTStageID { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<short> OldSingleOT { get; set; }
        public Nullable<short> NewSingleOT { get; set; }
        public Nullable<short> OldDoubleOT { get; set; }
        public Nullable<short> NewDoubleOT { get; set; }
        public Nullable<short> OldCPLConverted { get; set; }
        public Nullable<short> NewCPLConverted { get; set; }
    }
}
