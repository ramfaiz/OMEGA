using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmployeeLeave
{
    [Column("leave_ent_ref_no")]
    public long LeaveEntRefNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("user_id")]
    public long UserId { get; set; }

    [Column("employee_name")]
    [StringLength(152)]
    public string? EmployeeName { get; set; }

    [Column("applied_date", TypeName = "date")]
    public DateTime? AppliedDate { get; set; }

    [Column("start_date", TypeName = "date")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "date")]
    public DateTime? EndDate { get; set; }

    [Column("no_of_days")]
    [StringLength(5)]
    public string? NoOfDays { get; set; }

    [Column("leave_month")]
    public short? LeaveMonth { get; set; }

    [Column("leave_year")]
    public int? LeaveYear { get; set; }

    [Column("leave_type_id")]
    public int? LeaveTypeId { get; set; }

    [Column("leave_type")]
    [StringLength(200)]
    public string? LeaveType { get; set; }

    [Column("reason")]
    [StringLength(500)]
    public string? Reason { get; set; }

    [Column("status_reason")]
    [StringLength(250)]
    public string? StatusReason { get; set; }

    [Column("is_approved")]
    public short? IsApproved { get; set; }

    [Column("file_path")]
    [StringLength(100)]
    public string? FilePath { get; set; }

    [Column("gender")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("supervisor_id")]
    public long? SupervisorId { get; set; }

    [Column("approver_id")]
    public long? ApproverId { get; set; }

    [Column("approval_notification")]
    [StringLength(50)]
    public string? ApprovalNotification { get; set; }

    [Column("is_viewed_spr")]
    public short? IsViewedSpr { get; set; }

    [Column("is_viewed_appr")]
    public short? IsViewedAppr { get; set; }

    [Column("is_viewed")]
    public short? IsViewed { get; set; }

    [Column("medical_certificate_url")]
    [StringLength(500)]
    [Unicode(false)]
    public string? MedicalCertificateUrl { get; set; }

    [Column("medical_certificate_file")]
    [StringLength(500)]
    [Unicode(false)]
    public string? MedicalCertificateFile { get; set; }

    [Column("is_ceo_appr")]
    public short? IsCeoAppr { get; set; }

    [Column("is_viewed_ceo")]
    public short? IsViewedCeo { get; set; }

    [Column("role_id")]
    public int? RoleId { get; set; }

    [Column("is_viewed_employee")]
    public short? IsViewedEmployee { get; set; }

    [Column("is_cancelled")]
    public short? IsCancelled { get; set; }

    [Column("cancellation_reason")]
    [StringLength(500)]
    public string? CancellationReason { get; set; }

    [Column("cancellation_date", TypeName = "date")]
    public DateTime? CancellationDate { get; set; }

    [Column("empt_status")]
    public int? EmptStatus { get; set; }

    [Column("approved_by")]
    public long? ApprovedBy { get; set; }
}
