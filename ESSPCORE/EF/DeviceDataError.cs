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
    
    public partial class DeviceDataError
    {
        public int PDeviceDataErrorID { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<System.DateTime> EntryTime { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<short> ReaderID { get; set; }
        public Nullable<byte> RdrDutyCode { get; set; }
        public Nullable<int> DeviceRegID { get; set; }
        public Nullable<int> ModeOfEntry { get; set; }
    }
}
