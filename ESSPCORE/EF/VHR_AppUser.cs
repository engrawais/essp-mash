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
    
    public partial class VHR_AppUser
    {
        public int PUserID { get; set; }
        public Nullable<int> UserEmpID { get; set; }
        public string UserName { get; set; }
        public Nullable<bool> UserStatus { get; set; }
        public Nullable<System.DateTime> UserLastActiveDate { get; set; }
        public Nullable<int> UserAccessTypeID { get; set; }
        public string UserRoleID { get; set; }
        public string UserEmployeeName { get; set; }
        public Nullable<int> UserFPID { get; set; }
        public Nullable<int> UserJobTitleID { get; set; }
        public Nullable<int> UserLocationID { get; set; }
        public string UserJobTitleName { get; set; }
        public string UserLocationName { get; set; }
        public Nullable<bool> MLeave { get; set; }
        public Nullable<bool> LeavePolicy { get; set; }
        public Nullable<bool> LeaveApplication { get; set; }
        public Nullable<bool> LeaveQuota { get; set; }
        public Nullable<bool> LeaveCF { get; set; }
        public Nullable<bool> MShift { get; set; }
        public Nullable<bool> Shift { get; set; }
        public Nullable<bool> ShiftChange { get; set; }
        public Nullable<bool> ShiftChangeEmp { get; set; }
        public Nullable<bool> Roster { get; set; }
        public Nullable<bool> MOvertime { get; set; }
        public Nullable<bool> OvertimePolicy { get; set; }
        public Nullable<bool> OvertimeAP { get; set; }
        public Nullable<bool> OvertimeENCPL { get; set; }
        public Nullable<bool> MAttendanceEditor { get; set; }
        public Nullable<bool> JobCard { get; set; }
        public Nullable<bool> DailyAttEditor { get; set; }
        public Nullable<bool> MonthlyAttEditor { get; set; }
        public Nullable<bool> CompanyStructure { get; set; }
        public Nullable<bool> MSettings { get; set; }
        public Nullable<bool> Reader { get; set; }
        public Nullable<bool> Holiday { get; set; }
        public Nullable<bool> DownloadTime { get; set; }
        public Nullable<bool> ServiceLog { get; set; }
        public Nullable<bool> MUser { get; set; }
        public Nullable<bool> AppUser { get; set; }
        public Nullable<bool> AppUserRole { get; set; }
        public Nullable<bool> Employee { get; set; }
        public Nullable<bool> Crew { get; set; }
        public Nullable<bool> OUCommon { get; set; }
        public Nullable<bool> JTCommon { get; set; }
        public Nullable<bool> FinancialYear { get; set; }
        public Nullable<bool> PayrollPeriod { get; set; }
        public Nullable<bool> TMSAdd { get; set; }
        public Nullable<bool> TMSEdit { get; set; }
        public Nullable<bool> TMSView { get; set; }
        public Nullable<bool> TMSDelete { get; set; }
        public Nullable<bool> Reports { get; set; }
        public Nullable<bool> MCompany { get; set; }
        public Nullable<bool> MAttendance { get; set; }
        public Nullable<bool> HasESSP { get; set; }
        public Nullable<int> LineManagerID { get; set; }
        public string LMUserName { get; set; }
        public string LMEmployeeName { get; set; }
        public Nullable<int> LMEmployeeID { get; set; }
        public string OEmpID { get; set; }
        public Nullable<bool> RMS { get; set; }
        public Nullable<bool> RMSPosition { get; set; }
        public Nullable<bool> RMSRequisition { get; set; }
        public Nullable<bool> RMSShortlisting { get; set; }
        public Nullable<bool> RMSInterviewManagement { get; set; }
        public Nullable<bool> RMSHiringNote { get; set; }
        public Nullable<bool> PMS { get; set; }
        public Nullable<bool> PMSBellCurve { get; set; }
        public Nullable<bool> PMSCompetency { get; set; }
        public Nullable<bool> PMSSetting { get; set; }
        public Nullable<bool> PMSCycle { get; set; }
        public string CommonLocationName { get; set; }
        public Nullable<int> CommonLocationID { get; set; }
        public string OfficialEmailID { get; set; }
        public Nullable<bool> RMSReporting { get; set; }
        public string Password { get; set; }
        public Nullable<bool> RMSMeritList { get; set; }
        public Nullable<bool> PROBATIONEVALUATION { get; set; }
        public Nullable<bool> RMSTestManagement { get; set; }
        public string DesignationName { get; set; }
        public Nullable<bool> RMSCandidateManager { get; set; }
        public Nullable<bool> FeedbackSession { get; set; }
        public string Status { get; set; }
        public string OUName { get; set; }
        public Nullable<int> OUID { get; set; }
    }
}
