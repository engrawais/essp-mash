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
    
    public partial class JobCardDetail
    {
        public long PJobDataID { get; set; }
        public int EmpID { get; set; }
        public System.DateTime DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public int JobCardTypeID { get; set; }
        public string Remarks { get; set; }
        public Nullable<short> WorkMin { get; set; }
        public Nullable<short> OtherValue { get; set; }
        public int JobCardAppID { get; set; }
    
        public virtual JobCardApp JobCardApp { get; set; }
        public virtual JobCardType JobCardType { get; set; }
    }
}
