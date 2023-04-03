using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmpShiftDetail
{
    [Column("shift_set_no")]
    public long ShiftSetNo { get; set; }

    [Column("shift_date", TypeName = "date")]
    public DateTime? ShiftDate { get; set; }

    [Column("week_id")]
    public int? WeekId { get; set; }

    [Column("week_name")]
    [StringLength(30)]
    public string? WeekName { get; set; }

    [Column("shift_name")]
    [StringLength(500)]
    public string? ShiftName { get; set; }

    [Column("empt_detail_ref_no")]
    public long? EmptDetailRefNo { get; set; }

    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("empt_set_ref_no")]
    public long? EmptSetRefNo { get; set; }

    [Column("shift_month")]
    public short? ShiftMonth { get; set; }

    [Column("shift_year")]
    public int? ShiftYear { get; set; }

    [Column("emp_first_name")]
    [StringLength(152)]
    public string? EmpFirstName { get; set; }

    [Column("shift_id")]
    public int? ShiftId { get; set; }

    [Column("emp_last_name")]
    [StringLength(50)]
    public string? EmpLastName { get; set; }

    [Column("emp_comp_id")]
    public long? EmpCompId { get; set; }

    [Column("emp_desg")]
    [StringLength(240)]
    public string? EmpDesg { get; set; }

    [Column("empt_dept_id")]
    public int? EmptDeptId { get; set; }
}
