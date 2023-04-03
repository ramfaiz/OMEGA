using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_RESIGNATION")]
public partial class HrTbResignation
{
    [Key]
    [Column("resig_id")]
    public long ResigId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("applied_date", TypeName = "date")]
    public DateTime? AppliedDate { get; set; }

    [Column("applied_time")]
    public TimeSpan? AppliedTime { get; set; }

    [Column("applied_by")]
    public long? AppliedBy { get; set; }

    [Column("reason")]
    public string? Reason { get; set; }

    [Column("approved_by")]
    public long? ApprovedBy { get; set; }

    [Column("approval_notification")]
    public long? ApprovalNotification { get; set; }

    [Column("is_viewed_supr")]
    public long? IsViewedSupr { get; set; }

    [Column("is_approved")]
    public long? IsApproved { get; set; }

    [Column("is_viewed")]
    public long? IsViewed { get; set; }

    [Column("is_cancelled")]
    public long? IsCancelled { get; set; }

    [Column("cancelled_date", TypeName = "date")]
    public DateTime? CancelledDate { get; set; }
}
