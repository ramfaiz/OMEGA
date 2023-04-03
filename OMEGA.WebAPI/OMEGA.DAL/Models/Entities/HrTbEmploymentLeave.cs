using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_EMPLOYMENT_LEAVE")]
public partial class HrTbEmploymentLeave
{
    [Key]
    [Column("empt_leave_ref_no")]
    public long EmptLeaveRefNo { get; set; }

    [Column("empt_detail_ref_no")]
    public long? EmptDetailRefNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("empt_org_id")]
    public long? EmptOrgId { get; set; }

    [Column("empt_comp_id")]
    public long? EmptCompId { get; set; }

    [Column("empt_dept_id")]
    public long? EmptDeptId { get; set; }

    [Column("empt_leave_type_id")]
    public int? EmptLeaveTypeId { get; set; }

    [Column("adj_carry_fwd_leave_days", TypeName = "numeric(18, 1)")]
    public decimal? AdjCarryFwdLeaveDays { get; set; }

    [Column("entitled_leave", TypeName = "numeric(18, 1)")]
    public decimal? EntitledLeave { get; set; }

    [Column("total_entitled_leave", TypeName = "numeric(18, 1)")]
    public decimal? TotalEntitledLeave { get; set; }

    [Column("pending_leave", TypeName = "numeric(18, 1)")]
    public decimal? PendingLeave { get; set; }

    [Column("submitted_leave", TypeName = "numeric(18, 1)")]
    public decimal? SubmittedLeave { get; set; }

    [Column("recommended_leave", TypeName = "numeric(18, 1)")]
    public decimal? RecommendedLeave { get; set; }

    [Column("approved_leave", TypeName = "numeric(18, 1)")]
    public decimal? ApprovedLeave { get; set; }

    [Column("locked_leave", TypeName = "numeric(18, 1)")]
    public decimal? LockedLeave { get; set; }

    [Column("earned_leave", TypeName = "numeric(18, 1)")]
    public decimal? EarnedLeave { get; set; }

    [Column("available_earned_leave", TypeName = "numeric(18, 1)")]
    public decimal? AvailableEarnedLeave { get; set; }

    [Column("balance_leave", TypeName = "numeric(18, 1)")]
    public decimal? BalanceLeave { get; set; }

    [Column("available_leave", TypeName = "numeric(18, 1)")]
    public decimal? AvailableLeave { get; set; }

    [Column("current_unpaid_days", TypeName = "numeric(18, 1)")]
    public decimal? CurrentUnpaidDays { get; set; }

    [Column("total_unpaid_days", TypeName = "numeric(18, 1)")]
    public decimal? TotalUnpaidDays { get; set; }

    [Column("total_paid_leaves", TypeName = "numeric(18, 1)")]
    public decimal? TotalPaidLeaves { get; set; }

    [Column("entitled_carry_fwd_leave_days", TypeName = "numeric(18, 1)")]
    public decimal? EntitledCarryFwdLeaveDays { get; set; }

    [Column("is_entitled_leave_encashment")]
    public byte? IsEntitledLeaveEncashment { get; set; }

    [Column("is_leave_encash_on_cessation")]
    public byte? IsLeaveEncashOnCessation { get; set; }

    [Column("is_verfied")]
    public byte? IsVerfied { get; set; }

    [Column("verified_by")]
    public int? VerifiedBy { get; set; }

    [Column("verified_remarks")]
    [StringLength(240)]
    public string? VerifiedRemarks { get; set; }

    [Column("prorated_leave_days", TypeName = "numeric(18, 1)")]
    public decimal? ProratedLeaveDays { get; set; }

    [Column("is_entitled_carry_fwd_leave")]
    public byte? IsEntitledCarryFwdLeave { get; set; }
}
