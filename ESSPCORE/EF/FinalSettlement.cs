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
    
    public partial class FinalSettlement
    {
        public int PFinalSettelmentID { get; set; }
        public Nullable<int> PPeriodID { get; set; }
        public Nullable<int> EmpID { get; set; }
        public Nullable<double> Gsalary { get; set; }
        public Nullable<System.DateTime> JoingDate { get; set; }
        public Nullable<System.DateTime> ResignDate { get; set; }
        public Nullable<System.DateTime> InactiveDate { get; set; }
        public Nullable<System.DateTime> LastWorkingDay { get; set; }
        public Nullable<int> VoucherNo { get; set; }
        public Nullable<double> Pay_PDay { get; set; }
        public Nullable<double> Pay_PDayAmount { get; set; }
        public Nullable<double> Pay_UPDays { get; set; }
        public Nullable<double> Pay_UPDaysAmount { get; set; }
        public Nullable<double> Pay_GratuityDays { get; set; }
        public Nullable<double> Pay_GratuityAmount { get; set; }
        public Nullable<double> Pay_ELEncashmentDays { get; set; }
        public Nullable<double> Pay_ELEncashmentAmount { get; set; }
        public Nullable<double> Pay_NoticePayDays { get; set; }
        public Nullable<double> Pay_NoticePayAmount { get; set; }
        public Nullable<double> Pay_OTEPaymentsDays { get; set; }
        public Nullable<double> Pay_OTEPaymentsAmount { get; set; }
        public Nullable<double> Pay_Arrear { get; set; }
        public Nullable<double> Pay_MedicalClaim { get; set; }
        public Nullable<double> Pay_TADA { get; set; }
        public Nullable<double> Pay_FuelExpence { get; set; }
        public Nullable<double> Pay_AnyOthers { get; set; }
        public Nullable<double> Pay_Bonus { get; set; }
        public Nullable<double> D_UnfulfilledNotice { get; set; }
        public Nullable<double> D_AdvanceSalry { get; set; }
        public Nullable<double> D_LWOP { get; set; }
        public Nullable<double> D_Loan { get; set; }
        public Nullable<double> D_IncomeTax { get; set; }
        public Nullable<double> D_EOBI { get; set; }
        public Nullable<double> D_PhoneCalls { get; set; }
        public Nullable<double> D_PropertyM { get; set; }
        public Nullable<double> D_ELDeduction { get; set; }
        public Nullable<double> D_Anyothers { get; set; }
        public Nullable<double> D_Totals { get; set; }
        public Nullable<int> SubmittedBy { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<System.DateTime> SubmittedDate { get; set; }
        public Nullable<System.DateTime> ChequePDate { get; set; }
        public string ChequeNo { get; set; }
        public Nullable<int> SubmittedTo { get; set; }
        public string Inword { get; set; }
        public string Remarks { get; set; }
    }
}
