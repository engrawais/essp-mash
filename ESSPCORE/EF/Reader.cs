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
    
    public partial class Reader
    {
        public short PReaderID { get; set; }
        public string ReaderName { get; set; }
        public byte ReaderDutyCodeID { get; set; }
        public string IpAdd { get; set; }
        public short IpPort { get; set; }
        public byte RdrTypeID { get; set; }
        public bool Status { get; set; }
        public Nullable<int> LocID { get; set; }
        public bool ClearRecords { get; set; }
        public string EmailTo { get; set; }
        public string EmailCC { get; set; }
    
        public virtual ReaderDutyCode ReaderDutyCode { get; set; }
        public virtual ReaderType ReaderType { get; set; }
    }
}
