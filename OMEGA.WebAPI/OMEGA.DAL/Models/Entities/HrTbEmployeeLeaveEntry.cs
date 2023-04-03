using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_EMPLOYEE_LEAVE_ENTRY")]
public partial class HrTbEmployeeLeaveEntry
{
    [Key]
    [Column("leave_ent_ref_no")]
    public long LeaveEntRefNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("leave_type_id")]
    public int? LeaveTypeId { get; set; }

    [Column("applied_date", TypeName = "date")]
    public DateTime? AppliedDate { get; set; }

    [Column("applied_by")]
    public long? AppliedBy { get; set; }

    [Column("remarks")]
    [StringLength(500)]
    public string? Remarks { get; set; }

    [Column("start_date", TypeName = "date")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "date")]
    public DateTime? EndDate { get; set; }

    [Column("leave_month")]
    public short? LeaveMonth { get; set; }

    [Column("leave_year")]
    public int? LeaveYear { get; set; }

    [Column("no_of_days")]
    [StringLength(5)]
    public string? NoOfDays { get; set; }

    [Column("reason")]
    [StringLength(500)]
    public string? Reason { get; set; }

    [Column("medical_certificate_url")]
    [StringLength(500)]
    [Unicode(false)]
    public string? MedicalCertificateUrl { get; set; }

    [Column("medical_certificate_file")]
    [StringLength(500)]
    [Unicode(false)]
    public string? MedicalCertificateFile { get; set; }

    [Column("is_approved")]
    public short? IsApproved { get; set; }

    [Column("status_reason")]
    [StringLength(250)]
    public string? StatusReason { get; set; }

    [Column("approved_by")]
    public long? ApprovedBy { get; set; }

    [Column("approval_notification")]
    [StringLength(50)]
    public string? ApprovalNotification { get; set; }

    [Column("is_viewed_spr")]
    public short? IsViewedSpr { get; set; }

    [Column("is_viewed_appr")]
    public short? IsViewedAppr { get; set; }

    [Column("is_viewed")]
    public short? IsViewed { get; set; }

    [Column("is_ceo_appr")]
    public short? IsCeoAppr { get; set; }

    [Column("is_viewed_ceo")]
    public short? IsViewedCeo { get; set; }

    [Column("is_viewed_employee")]
    public short? IsViewedEmployee { get; set; }

    [Column("is_cancelled")]
    public short? IsCancelled { get; set; }

    [Column("cancellation_reason")]
    [StringLength(500)]
    public string? CancellationReason { get; set; }

    [Column("cancellation_date", TypeName = "date")]
    public DateTime? CancellationDate { get; set; }
}
