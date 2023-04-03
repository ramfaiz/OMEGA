using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwRejectedLeaveList
{
    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("employee_name")]
    [StringLength(152)]
    public string? EmployeeName { get; set; }

    [Column("reason")]
    [StringLength(500)]
    public string? Reason { get; set; }

    [Column("no_of_days")]
    [StringLength(5)]
    public string? NoOfDays { get; set; }

    [Column("is_approved")]
    public short? IsApproved { get; set; }

    [Column("status_reason")]
    [StringLength(250)]
    public string? StatusReason { get; set; }

    [Column("approved_by")]
    public long? ApprovedBy { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("is_cancelled")]
    public short? IsCancelled { get; set; }

    [Column("rejected_by_name")]
    [StringLength(152)]
    public string? RejectedByName { get; set; }

    [Column("leave_ent_ref_no")]
    public long LeaveEntRefNo { get; set; }

    [StringLength(63)]
    [Unicode(false)]
    public string? LeaveDate { get; set; }
}
