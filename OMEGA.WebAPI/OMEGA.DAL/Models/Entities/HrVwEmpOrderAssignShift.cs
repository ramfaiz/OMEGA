using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmpOrderAssignShift
{
    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("emp_first_name")]
    [StringLength(50)]
    public string? EmpFirstName { get; set; }

    [Column("emp_title")]
    [StringLength(50)]
    public string? EmpTitle { get; set; }

    [Column("shift_id")]
    public int? ShiftId { get; set; }

    [Column("shift_month")]
    public short? ShiftMonth { get; set; }

    [Column("shift_year")]
    public int? ShiftYear { get; set; }

    [Column("shift_date", TypeName = "date")]
    public DateTime? ShiftDate { get; set; }

    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }

    [Column("role_id")]
    public int? RoleId { get; set; }
}
