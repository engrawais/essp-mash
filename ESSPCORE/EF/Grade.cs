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
    
    public partial class Grade
    {
        public int PGradeID { get; set; }
        public string GradeName { get; set; }
        public string OGradeID { get; set; }
        public bool Status { get; set; }
        public Nullable<short> OTPolicyID { get; set; }
        public Nullable<short> ALPolicyID { get; set; }
        public Nullable<short> CLPolicyID { get; set; }
        public Nullable<short> CPLPolicyID { get; set; }
        public Nullable<short> SLPolicyID { get; set; }
    }
}
