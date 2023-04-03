using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_EMPLOYMENT_DETAILS")]
public partial class HrTbEmploymentDetail
{
    [Key]
    [Column("empt_detail_ref_no")]
    public long EmptDetailRefNo { get; set; }

    [Column("empt_ref_no")]
    public long? EmptRefNo { get; set; }

    [Column("empt_set_ref_no")]
    public long? EmptSetRefNo { get; set; }

    [Column("emp_ref_no")]
    public int? EmpRefNo { get; set; }

    [Column("empt_org_id")]
    public int? EmptOrgId { get; set; }

    [Column("empt_comp_id")]
    public int? EmptCompId { get; set; }

    [Column("empt_dept_id")]
    public int? EmptDeptId { get; set; }

    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }

    [Column("seq_no")]
    public byte? SeqNo { get; set; }

    [Column("joining_date", TypeName = "datetime")]
    public DateTime? JoiningDate { get; set; }

    [Column("confirmation_date", TypeName = "datetime")]
    public DateTime? ConfirmationDate { get; set; }

    [Column("probation_period")]
    public int? ProbationPeriod { get; set; }

    [Column("termination_date", TypeName = "datetime")]
    public DateTime? TerminationDate { get; set; }

    [Column("temination_reason")]
    [StringLength(240)]
    public string? TeminationReason { get; set; }

    [Column("empt_type")]
    public int? EmptType { get; set; }

    [Column("empt_start_date", TypeName = "datetime")]
    public DateTime? EmptStartDate { get; set; }

    [Column("empt_end_date", TypeName = "datetime")]
    public DateTime? EmptEndDate { get; set; }

    [Column("resignation_date", TypeName = "datetime")]
    public DateTime? ResignationDate { get; set; }

    [Column("resignation_reason")]
    [StringLength(500)]
    public string? ResignationReason { get; set; }

    [Column("empt_status")]
    public int? EmptStatus { get; set; }

    [Column("notice_period")]
    public int? NoticePeriod { get; set; }

    [Column("notice_period_in")]
    [StringLength(4)]
    public string? NoticePeriodIn { get; set; }

    [Column("work_day_type")]
    public int? WorkDayType { get; set; }

    [Column("weekly_work_days")]
    public int? WeeklyWorkDays { get; set; }

    [Column("is_salary_counted_by_calendar_days")]
    public byte? IsSalaryCountedByCalendarDays { get; set; }

    [Column("overtime_payment_entitlement")]
    public byte? OvertimePaymentEntitlement { get; set; }

    [Column("entitled_holiday_pay")]
    public byte? EntitledHolidayPay { get; set; }

    [Column("entitled_holiday_pay_remarks")]
    [StringLength(500)]
    public string? EntitledHolidayPayRemarks { get; set; }

    [Column("is_entitled_medical_benefit")]
    public byte? IsEntitledMedicalBenefit { get; set; }

    [Column("is_entitled_dental_benefit")]
    public byte? IsEntitledDentalBenefit { get; set; }

    [Column("medical_benefit_amount", TypeName = "numeric(18, 3)")]
    public decimal? MedicalBenefitAmount { get; set; }

    [Column("dental_benefit_amount", TypeName = "numeric(18, 3)")]
    public decimal? DentalBenefitAmount { get; set; }

    [Column("is_entitled_insurance")]
    public byte? IsEntitledInsurance { get; set; }

    [Column("insurance_type1")]
    public int? InsuranceType1 { get; set; }

    [Column("insurance_type2")]
    public int? InsuranceType2 { get; set; }

    [Column("insurance_amount", TypeName = "numeric(18, 3)")]
    public decimal? InsuranceAmount { get; set; }

    [Column("empt_payday_cycle")]
    [StringLength(18)]
    [Unicode(false)]
    public string? EmptPaydayCycle { get; set; }

    [Column("empt_payday", TypeName = "numeric(18, 2)")]
    public decimal? EmptPayday { get; set; }

    [Column("is_verfied")]
    public byte? IsVerfied { get; set; }

    [Column("verified_by")]
    public int? VerifiedBy { get; set; }

    [Column("verified_remarks")]
    [StringLength(240)]
    public string? VerifiedRemarks { get; set; }

    [Column("assignment_desc")]
    [StringLength(500)]
    public string? AssignmentDesc { get; set; }

    [Column("previous_empt_refno")]
    public long? PreviousEmptRefno { get; set; }

    [Column("hold_pay")]
    public byte? HoldPay { get; set; }

    [Column("in_use")]
    public byte? InUse { get; set; }

    [Column("latest_pay_ref_no")]
    public long? LatestPayRefNo { get; set; }

    [Column("latest_pay_ref_reset")]
    public long? LatestPayRefReset { get; set; }

    [Column("supervisor_id")]
    public long? SupervisorId { get; set; }

    [Column("approver_id")]
    public long? ApproverId { get; set; }

    [Column("next_payment_date", TypeName = "datetime")]
    public DateTime? NextPaymentDate { get; set; }

    [Column("empt_actual_end_date", TypeName = "datetime")]
    public DateTime? EmptActualEndDate { get; set; }

    [Column("resignation_type")]
    public short? ResignationType { get; set; }

    [Column("status_reason_id")]
    public short? StatusReasonId { get; set; }

    [Column("resignation_remarks")]
    [StringLength(100)]
    public string? ResignationRemarks { get; set; }

    [Column("is_medical_encash")]
    public byte? IsMedicalEncash { get; set; }

    [Column("is_medical_EncashOnCessation")]
    public byte? IsMedicalEncashOnCessation { get; set; }

    [Column("per_visit_medical_amount", TypeName = "numeric(18, 3)")]
    public decimal? PerVisitMedicalAmount { get; set; }

    [Column("is_dental_encash")]
    public byte? IsDentalEncash { get; set; }

    [Column("is_dental_EncashOnCessation")]
    public byte? IsDentalEncashOnCessation { get; set; }

    [Column("per_visit_dental_amount", TypeName = "numeric(18, 3)")]
    public decimal? PerVisitDentalAmount { get; set; }

    [Column("claim_benefit_type")]
    public byte? ClaimBenefitType { get; set; }

    [Column("eligible_medical_amount", TypeName = "numeric(18, 3)")]
    public decimal? EligibleMedicalAmount { get; set; }

    [Column("medical_claim_amt_paid", TypeName = "numeric(18, 3)")]
    public decimal? MedicalClaimAmtPaid { get; set; }

    [Column("last_proc_medical_claim_dt", TypeName = "datetime")]
    public DateTime? LastProcMedicalClaimDt { get; set; }

    [Column("eligible_dental_amount", TypeName = "numeric(18, 3)")]
    public decimal? EligibleDentalAmount { get; set; }

    [Column("dental_claim_amt_paid", TypeName = "numeric(18, 3)")]
    public decimal? DentalClaimAmtPaid { get; set; }

    [Column("last_proc_dental_claim_dt", TypeName = "datetime")]
    public DateTime? LastProcDentalClaimDt { get; set; }

    [Column("shift_id")]
    public byte? ShiftId { get; set; }

    [Column("night_shift")]
    public short? NightShift { get; set; }
}
