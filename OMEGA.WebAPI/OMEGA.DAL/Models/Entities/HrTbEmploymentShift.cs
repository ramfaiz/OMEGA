using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_EMPLOYMENT_SHIFT")]
public partial class HrTbEmploymentShift
{
    [Key]
    [Column("shift_set_no")]
    public long ShiftSetNo { get; set; }

    [Column("shift_date", TypeName = "date")]
    public DateTime? ShiftDate { get; set; }

    [Column("shift_id")]
    public int? ShiftId { get; set; }

    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("empt_detail_ref_no")]
    public long? EmptDetailRefNo { get; set; }

    [Column("empt_set_ref_no")]
    public long? EmptSetRefNo { get; set; }

    [Column("shift_month")]
    public short? ShiftMonth { get; set; }

    [Column("shift_year")]
    public int? ShiftYear { get; set; }

    [Column("shift_day")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ShiftDay { get; set; }
}
