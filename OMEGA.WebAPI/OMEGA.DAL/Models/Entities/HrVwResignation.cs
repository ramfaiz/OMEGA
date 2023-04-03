using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwResignation
{
    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("applied_date", TypeName = "date")]
    public DateTime? AppliedDate { get; set; }

    [Column("applied_time")]
    public TimeSpan? AppliedTime { get; set; }

    [Column("employee_name")]
    [StringLength(152)]
    public string? EmployeeName { get; set; }

    [Column("department")]
    [StringLength(240)]
    public string? Department { get; set; }

    [Column("location")]
    [StringLength(240)]
    [Unicode(false)]
    public string? Location { get; set; }

    [Column("reason")]
    public string? Reason { get; set; }

    [Column("is_cancelled")]
    public long? IsCancelled { get; set; }

    [Column("is_approved")]
    public long? IsApproved { get; set; }

    [Column("approval_notification")]
    public long? ApprovalNotification { get; set; }
}
