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
    
    public partial class VAT_DailyAttendance
    {
        public Nullable<int> EmpID { get; set; }
        public Nullable<int> FPID { get; set; }
        public string EmployeeName { get; set; }
        public string FatherName { get; set; }
        public string Status { get; set; }
        public Nullable<int> EmploymentTypeID { get; set; }
        public Nullable<int> DesigationID { get; set; }
        public Nullable<int> JobTitleID { get; set; }
        public Nullable<int> GradeID { get; set; }
        public Nullable<int> OUID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<System.DateTime> ResignDate { get; set; }
        public Nullable<short> ShiftID { get; set; }
        public string CardNo { get; set; }
        public Nullable<System.DateTime> ValidDate { get; set; }
        public Nullable<bool> ProcessAttendance { get; set; }
        public Nullable<short> OTPolicyID { get; set; }
        public string LocationName { get; set; }
        public string EmploymentTypeName { get; set; }
        public string GradeName { get; set; }
        public string OGradeID { get; set; }
        public string OJobTitleID { get; set; }
        public string JobTitleName { get; set; }
        public string DesignationName { get; set; }
        public string ODesignationID { get; set; }
        public string OEmployeementTypeID { get; set; }
        public string OLocationID { get; set; }
        public string OTPolicyName { get; set; }
        public string ShiftName { get; set; }
        public string OEmpID { get; set; }
        public Nullable<System.DateTime> DOJ { get; set; }
        public string CrewName { get; set; }
        public Nullable<int> CrewID { get; set; }
        public Nullable<int> ALPolicyID { get; set; }
        public string ALPolicyName { get; set; }
        public Nullable<int> CLPolicyID { get; set; }
        public string CLPolicyName { get; set; }
        public Nullable<int> SLPolicyID { get; set; }
        public string SLPolicyName { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> CPLPolicyID { get; set; }
        public string CPLPolicyName { get; set; }
        public Nullable<bool> FPTemp { get; set; }
        public string OUName { get; set; }
        public string OOUID { get; set; }
        public string OUCommonName { get; set; }
        public Nullable<int> OUCommonID { get; set; }
        public Nullable<int> JTCommonID { get; set; }
        public string JTCommonName { get; set; }
        public Nullable<System.DateTime> AttDate { get; set; }
        public string DutyCode { get; set; }
        public Nullable<System.TimeSpan> DutyTime { get; set; }
        public Nullable<System.DateTime> TimeIn { get; set; }
        public Nullable<System.DateTime> TimeOut { get; set; }
        public Nullable<short> WorkMin { get; set; }
        public Nullable<double> PDays { get; set; }
        public Nullable<double> AbDays { get; set; }
        public Nullable<double> LeaveDays { get; set; }
        public Nullable<short> LateIn { get; set; }
        public Nullable<short> LateOut { get; set; }
        public Nullable<short> EarlyIn { get; set; }
        public Nullable<short> EarlyOut { get; set; }
        public Nullable<short> ExtraMin { get; set; }
        public Nullable<short> OTMin { get; set; }
        public Nullable<short> GZOTMin { get; set; }
        public Nullable<short> BreakMin { get; set; }
        public Nullable<short> TotalShortMin { get; set; }
        public Nullable<short> ActualOT { get; set; }
        public Nullable<short> SLMin { get; set; }
        public Nullable<bool> StatusP { get; set; }
        public Nullable<bool> StatusAB { get; set; }
        public Nullable<bool> StatusEI { get; set; }
        public Nullable<bool> StatusEO { get; set; }
        public Nullable<bool> StatusLI { get; set; }
        public Nullable<bool> StatusLO { get; set; }
        public Nullable<bool> StatusOT { get; set; }
        public Nullable<bool> StatusGZOT { get; set; }
        public Nullable<bool> StatusGZ { get; set; }
        public Nullable<bool> StatusSL { get; set; }
        public Nullable<bool> StatusDO { get; set; }
        public Nullable<bool> StatusOD { get; set; }
        public Nullable<bool> StatusHL { get; set; }
        public Nullable<bool> StatusLeave { get; set; }
        public Nullable<bool> StatusMN { get; set; }
        public Nullable<bool> StatusIN { get; set; }
        public Nullable<bool> StatusBreak { get; set; }
        public Nullable<short> ShifMin { get; set; }
        public Nullable<short> BreakMins { get; set; }
        public string Remarks { get; set; }
        public string EmpDate { get; set; }
        public string CommonLocationName { get; set; }
        public Nullable<int> CommonLocationID { get; set; }
        public Nullable<short> JCMins { get; set; }
        public Nullable<short> ApprovedOT { get; set; }
        public Nullable<short> ApprovedDoubleOT { get; set; }
        public Nullable<short> ApprovedCPL { get; set; }
    }
}
