using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_EMPLOYMENT_SHIFT_TEMPLATE")]
public partial class HrTbEmploymentShiftTemplate
{
    [Key]
    [Column("tpl_ref_no")]
    public long TplRefNo { get; set; }

    [Column("week_day_id")]
    public byte? WeekDayId { get; set; }

    [Column("shift_id")]
    public int? ShiftId { get; set; }

    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("empt_detail_ref_no")]
    public long? EmptDetailRefNo { get; set; }

    [Column("prev_month_end")]
    public byte? PrevMonthEnd { get; set; }
}
