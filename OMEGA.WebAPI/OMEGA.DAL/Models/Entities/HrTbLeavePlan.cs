using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_LEAVE_PLAN")]
public partial class HrTbLeavePlan
{
    [Key]
    [Column("leave_plan_id")]
    public long LeavePlanId { get; set; }

    [Column("leave_date", TypeName = "date")]
    public DateTime? LeaveDate { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("emp_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName { get; set; }

    [Column("reason")]
    [StringLength(500)]
    public string? Reason { get; set; }
}
