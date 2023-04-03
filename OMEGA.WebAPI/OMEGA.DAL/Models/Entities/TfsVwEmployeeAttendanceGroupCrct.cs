using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class TfsVwEmployeeAttendanceGroupCrct
{
    [Column("sl_no")]
    public int SlNo { get; set; }

    [Column("grp_id")]
    public int? GrpId { get; set; }

    [Column("emp_ref_no")]
    public int? EmpRefNo { get; set; }

    [Column("leave_entry_no")]
    public int? LeaveEntryNo { get; set; }

    [Column("leave_date", TypeName = "datetime")]
    public DateTime? LeaveDate { get; set; }

    [Column("leave_type")]
    public int? LeaveType { get; set; }

    [Column("manager")]
    public int? Manager { get; set; }

    [Column("no_of_days")]
    public double? NoOfDays { get; set; }

    [Column("reason")]
    public string? Reason { get; set; }

    [Column("priority")]
    public int? Priority { get; set; }

    [Column("assign_count")]
    public int? AssignCount { get; set; }

    [Column("insp_count")]
    public int? InspCount { get; set; }
}
